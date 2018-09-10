using UnityEngine;
using UnityEngine.UI;

public class ViewSampleWindow : View
{
	[SerializeField]
	private Button _buttonShowHideCollectionWindow = null;

	[SerializeField]
	private Text _textCaption = null;

	public Button ButtonShowHideCollectionWindow
	{
		get { return _buttonShowHideCollectionWindow; }
	}

	public Text TextCaption
	{
		get { return _textCaption; }
	}
}
