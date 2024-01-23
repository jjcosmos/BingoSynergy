using Godot;
using System;
using BingusLines;

public partial class AddActionButton : Control
{
	[Export] private FilterBox _filterBox;
	[Export] private Button _addActionButton;
	public override void _Ready()
	{
		DependencyEditorView.DataLoaded += DataLoaded;
		_addActionButton.Pressed += AddActionButtonOnPressed;
	}

	private void AddActionButtonOnPressed()
	{
		if(!string.IsNullOrWhiteSpace(_filterBox.GetSelection()))
		{
			DependencyEditorView.Singleton.AddActionEntry(_filterBox.GetSelection(), true);
		}
	}

	private void DataLoaded(UserData data)
	{
		GD.Print($"Data loaded {data.BingoActions.Count} actions");
		_filterBox.SetItems(data.BingoActions);
	}
}
