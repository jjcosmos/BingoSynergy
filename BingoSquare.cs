using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Godot;

namespace BingusLines;

public partial class BingoSquare : Panel
{
    [Export] private LineEdit _filter;
    [Export] private OptionButton _optionButton;
    [Export] private Label _ratingLabel;
    [Export] private ColorRect _highlight;
    [Export] private Label _synergies;

    private BingoGoal _selectedGoal;
    //private BingoGoal[] _possibleSelections;

    public static readonly string[] _EnumOptionsAsStr = Enum.GetValues(typeof(BingoGoal))
        .Cast<BingoGoal>()
        .Select(v => v.ToString())
        .ToArray();

    public static readonly BingoGoal[] _EnumOptions = Enum.GetValues(typeof(BingoGoal))
        .Cast<BingoGoal>()
        .ToArray();

    public override void _Ready()
    {
        _filter.TextChanged += FilterOnTextChanged;
        _optionButton.ItemSelected += OptionButtonOnItemSelected;
    }
    
    private void OptionButtonOnItemSelected(long index)
    {
        var item = _optionButton.GetItemId((int)index);
        _selectedGoal = EnumOptions[item];
        _filter.Text = _selectedGoal.ToString();
    }

    public void SetSynergiesText(List<BingoAction> synergies)
    {
        var builder = new StringBuilder();
        foreach (var action in synergies.ToHashSet())
        {
            builder.AppendLine($"-{action.ToString()}");
        }

        //_synergies.Text = builder.ToString();
        _highlight.TooltipText = builder.ToString();
    }
    
    public void SetSynergiesTextStr(List<string> synergies)
    {
        var builder = new StringBuilder();
        foreach (var action in synergies.ToHashSet())
        {
            builder.AppendLine($"-{action}");
        }

        //_synergies.Text = builder.ToString();
        _highlight.TooltipText = builder.ToString();
    }

    public void SetRatingValue(float rating, float max, Color low, Color high)
    {
        _highlight.Color = low.Lerp(high, rating / max);
        _ratingLabel.Text = rating.ToString();
    }

    private void FilterOnTextChanged(string newtext)
    {
        newtext = newtext.Trim();
        
        _optionButton.Clear();

        for (var index = 0; index < EnumOptionsAsStr.Length; index++)
        {
            var enumOpt = EnumOptionsAsStr[index];
            if (string.IsNullOrWhiteSpace(newtext) || enumOpt.ToLower().Contains(newtext.ToLower()))
            {
                _optionButton.AddItem(enumOpt, index);
            }
        }
    }

    public BingoGoal GetGoal()
    {
        return _selectedGoal;
    }

    public string GetGoalStr()
    {
        return _selectedGoal.ToString();
    }

    public void SetGoal(BingoGoal bingoGoal)
    {
        _selectedGoal = bingoGoal;
        _filter.Text = _selectedGoal.ToString();
    }
}