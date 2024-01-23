using Godot;
using System;

public partial class ActionListEntry : Control
{
	[Export] private Label _label;
	[Export] private Button _removeSelfButton;

	public string Action { get; private set; }
	public override void _Ready()
	{
		_removeSelfButton.Pressed += RemoveSelfButtonOnPressed;
	}

	public void SetAction(string action)
	{
		Action = action;
		_label.Text = action;
	}

	private void RemoveSelfButtonOnPressed()
	{
		DependencyEditorView.Singleton.RemoveActionEntry(this);
	}

}
