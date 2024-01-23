using Godot;
using System.Collections.Generic;
using System.Linq;

public partial class FilterBox : Control
{
	[Export] private LineEdit _lineEdit;
	[Export] private OptionButton _optionButton;
	
	private List<string> _items = new();
	private List<string> _visible = new();
	private string _selected;

	public void SetItems(List<string> sourceItems)
	{
		_items = sourceItems.ToList();
		_visible = sourceItems.ToList();
		
		ShowVisible();
	}
	
	public override void _Ready()
	{
		_optionButton.AllowReselect = true;
		_optionButton.ItemSelected += OptionButtonOnItemSelected;
		_lineEdit.TextChanged += LineEditOnTextChanged;
	}

	public string GetSelection()
	{
		return _selected;
	}

	private void LineEditOnTextChanged(string newText)
	{
		newText = newText.Trim();
		_visible.Clear();
		
		foreach (var item in _items)
		{
			if (string.IsNullOrWhiteSpace(newText) || item.ToLower().Contains(newText.ToLower()))
			{
				_visible.Add(item);
			}
		}
		
		GD.Print($"Showing {_visible.Count} items");
		
		ShowVisible();
	}

	private void ShowVisible()
	{
		_optionButton.Clear();
		foreach (var item in _visible)
		{
			_optionButton.AddItem(item);
		}
	}

	private void OptionButtonOnItemSelected(long index)
	{
		_selected = _visible[(int)index];
		_lineEdit.Text = _selected;
	}
}
