using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using BingusLines;

public partial class DependencyEditorView : Control
{
	// Called when the node enters the scene tree for the first time.
	public static Action<UserData> DataLoaded;
	private UserData _userData;
	public static DependencyEditorView Singleton;

	private UserGoalEntry _selectedGoal;
	private List<ActionListEntry> _actionListEntries = new();

	[Export] private PackedScene _goalEntryScene;
	[Export] private PackedScene _actionEntryScene;
	[Export] private BoxContainer _actionParent;
	[Export] private BoxContainer _goalParent;
	[Export] private Button _backButton;
	[Export] private Button _saveButton;

	public override async void _Ready()
	{
		Singleton = this;
		_userData = new UserData();
		_userData.ReadFilesFromDisk();
		await ToSignal(GetTree(), "process_frame");
		DataLoaded?.Invoke(_userData);

		foreach (var bingoGoal in _userData.BingoGoals)
		{
			if (bingoGoal.ToUpper() == "NONE") continue;
			
			var goalEntry = _goalEntryScene.Instantiate() as UserGoalEntry;
			_goalParent.AddChild(goalEntry);
			goalEntry?.SetGoal(bingoGoal);
		}
		
		_backButton.Pressed += BackButtonOnPressed;
		_saveButton.Pressed += SaveButtonOnPressed;
	}

	private void SaveButtonOnPressed()
	{
		_userData.WriteFilesToDisk();
	}

	private void BackButtonOnPressed()
	{
		BingoView.Singleton.SetMode(BingoView.Mode.BoardView);
	}
	

	public void GoalItemSelected(UserGoalEntry goalEntry)
	{
		_selectedGoal = goalEntry;
		// Clear action entries
		foreach (var actionListEntry in _actionListEntries)
		{
			actionListEntry.QueueFree();
		}
		_actionListEntries.Clear();
		
		// Add entries from data
		foreach (var action in _userData.BingoDeps[goalEntry.Goal])
		{
			AddActionEntry(action);
		}
	}

	public void AddActionEntry(string action, bool addToData = false)
	{
		if (_selectedGoal == null) return;
		
		if (_actionListEntries.All(x => x.Action != action))
		{
			var inst = _actionEntryScene.Instantiate() as ActionListEntry;
			_actionParent.AddChild(inst);
			inst?.SetAction(action);
			_actionListEntries.Add(inst);
			
			if(addToData)
				_userData.BingoDeps[_selectedGoal.Goal].Add(action);
		}
	}

	public void RemoveActionEntry(ActionListEntry actionListEntry)
	{
		var found = _actionListEntries.Find(x => x == actionListEntry);
		if (found == null) return;

		_userData.BingoDeps[_selectedGoal.Goal].Remove(found.Action);
		found.QueueFree();
		_actionListEntries.Remove(found);
	}

	public void SaveUserData()
	{
		
	}
}
