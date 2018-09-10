using UnityEngine;
using UnityEngine.UI;

public class ViewSampleCollection : View
{
	[SerializeField]
	private Button _buttonAddItem;
	
	[SerializeField]
	private Button _buttonClear;

	[SerializeField]
	private Text _textCaption;

	[SerializeField] 
	private UICollection _collection;

	public Button ButtonAddItem { get { return _buttonAddItem; } }
	
	public Button ButtonClear { get { return _buttonClear; } }

	public Text TextCaption { get { return _textCaption; } }
	
	public UICollection Collection { get { return _collection; } } 
}
