using Godot;
using System;

public partial class UserGoalEntry : Control
{
	[Export] private Button _button;
	
	public string Goal { get; private set; }

	public override void _Ready()
	{
		_button.Pressed += ButtonOnPressed;
	}

	private void ButtonOnPressed()
	{
		DependencyEditorView.Singleton.GoalItemSelected(this);
	}

	public void SetGoal(string goal)
	{
		Goal = goal;
		_button.Text = goal;
	}
}
