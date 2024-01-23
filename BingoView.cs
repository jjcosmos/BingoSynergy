using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Godot;

namespace BingusLines;

public partial class BingoView : Node
{
    [Export] private Button _createBoardButton;
    [Export] private LineEdit _dimsEdit;
    [Export] private GridContainer _gridContainer;
    [Export] private PackedScene _squareScene;
    [Export] private Button _analyzeButton;
    [Export] private Button _testFillButton;
    [Export] private Button _dependencyEditorButton;
    [Export] private ColorPickerButton _colorButtonLow;
    [Export] private ColorPickerButton _colorButtonHigh;
    [Export] private DependencyEditorView _dependencyEditor;
    [Export] private Control _boardView;

    private float _gridSize;
    private List<BingoSquare> _instancedSquares = new();

    public static BingoView Singleton;
    public UserData UserData;

    public override void _Ready()
    {
        _createBoardButton.Pressed += CreateBoardButtonOnPressed;
        _analyzeButton.Pressed += AnalyzeButtonOnPressed;
        _testFillButton.Pressed += TestFillButtonOnPressed;
        _dependencyEditorButton.Pressed += DependencyEditorButtonOnPressed;
        _gridSize = MathF.Min(_gridContainer.Size.X, _gridContainer.Size.Y);

        Singleton = this;
        UserData = new UserData();
        UserData.ReadFilesFromDisk();

        //var userData = new UserData();
        //userData.MigrateFromCSource();
        
        SetMode(Mode.BoardView);
    }

    private void DependencyEditorButtonOnPressed()
    {
        SetMode(Mode.DependencyEditorView);
    }

    public enum Mode
    {
        BoardView,
        DependencyEditorView,
    }
    
    public void SetMode(Mode mode)
    {
        _boardView.Visible = mode == Mode.BoardView;
        _dependencyEditor.Visible = mode == Mode.DependencyEditorView;
        UserData.ReadFilesFromDisk();
    }

    /*private void WriteJsonToDisk()
    {
        var actionedGoals = SynergyApp.Data;
        var actions = Enum.GetValues(typeof(BingoAction)).Cast<BingoAction>().Select(x => $"BingoAction.{x}").ToList();
        var goals = Enum.GetValues(typeof(BingoGoal)).Cast<BingoGoal>().Select(x => $"BingoGoal.{x}").ToList();

        var toSer = new SerializableSchema()
        {
            MergedData = actionedGoals,
            Actions = actions,
            Goals = goals,
        };

        var options = new JsonSerializerOptions() { WriteIndented = true };
        var asJson = JsonSerializer.Serialize(toSer, options);
        var stream = System.IO.File.Create("BingoSchema.json");
        var bytes = new UTF8Encoding(true).GetBytes(asJson);
        stream.Write(bytes, 0, bytes.Length);
        stream.Close();
    }*/
    
    private class SerializableSchema
    {
        public List<BingoGoalWithActions> MergedData { get; set; }
        public List<string> Actions { get; set; }
        public List<string> Goals { get; set; }
    }

    private void TestFillButtonOnPressed()
    {
        var rand = new RandomNumberGenerator();
        if (_instancedSquares.Count > 0)
        {
            var goalOptions = BingoView.Singleton.UserData.BingoGoals;
            var shuffled = goalOptions.OrderBy(x => rand.Randi())
                .Where(x => x != "None")
                .ToList();
            for (var index = 0; index < _instancedSquares.Count; index++)
            {
                var instancedSquare = _instancedSquares[index];
                instancedSquare.SetGoal(shuffled[index]);
            }
        }
    }

    private void AnalyzeButtonOnPressed()
    {
        var dim = _gridContainer.Columns;

        if (_instancedSquares.Any(x => x.GetGoalStr() == "None"))
        {
            GD.PrintErr("All Squares must be valid");
            return;
        }

        // var board = new BingoGoal[dim, dim];
        // for (var i = 0; i < dim * dim; i++)
        // {
        //     var indX = i % dim;
        //     var indY = i / dim;
        //     board[indY, indX] = _instancedSquares[i].GetGoal();
        // }

        /*var builder = new StringBuilder();
        for (var index0 = 0; index0 < board.GetLength(0); index0++)
        {
            for (var index1 = 0; index1 < board.GetLength(1); index1++)
            {
                var goal = board[index0, index1];
                builder.Append(goal.ToString().PadRight(30));
            }

            builder.AppendLine();
        }
        GD.Print(builder.ToString());*/

        var board = new string[dim, dim];
        for (var i = 0; i < dim * dim; i++)
        {
            var indX = i % dim;
            var indY = i / dim;
            board[indY, indX] = _instancedSquares[i].GetGoalStr();
        }

        var userData = new UserData();
        userData.ReadFilesFromDisk();
        
        var lineRatings = SynergyApp.GetLineRatingsStr(board, userData.BingoDeps);
        lineRatings.Reverse();

        var max = lineRatings.Max(x => x.Rating);
        
        foreach (var line in lineRatings)
        {
            foreach (var bingoGoal in line.Line)
            {
                var found = _instancedSquares.First(x => x.GetGoalStr() == bingoGoal);
                found.SetRatingValue(line.Rating, max, _colorButtonLow.Color, _colorButtonHigh.Color);
                found.SetSynergiesTextStr(line.Synergies);
            }
        }
    }

    private void CreateBoardButtonOnPressed()
    {
        if (!int.TryParse(_dimsEdit.Text.Trim(), out var value))
        {
            return;
        }

        _gridContainer.Columns = value;

        foreach (var instancedSquare in _instancedSquares)
        {
            instancedSquare.QueueFree();
        }

        var width = (_gridSize / value) - 1;
        _gridContainer.AddThemeConstantOverride("h_separation",0);
        _gridContainer.AddThemeConstantOverride("v_separation",0);
        _instancedSquares.Clear();

        for (var i = 0; i < value * value; i++)
        {
            var inst = _squareScene.Instantiate() as BingoSquare;
            _gridContainer.AddChild(inst);
            _instancedSquares.Add(inst);
            inst.CustomMinimumSize = Vector2.One * width;
            inst.UpdateMinimumSize();
        }
    }
}