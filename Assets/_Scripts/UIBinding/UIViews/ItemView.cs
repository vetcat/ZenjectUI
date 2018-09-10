using UnityEngine;
using UnityEngine.UI;

public class ItemView : View
{
	public int Id;
	
	[SerializeField]
	private Button _buttonSelect;

	[SerializeField]
	private Text _textCaption;

	public Button ButtonSelect
	{
		get { return _buttonSelect ; }
	}

	public Text Caption
	{
		get { return _textCaption; }
	}
}
