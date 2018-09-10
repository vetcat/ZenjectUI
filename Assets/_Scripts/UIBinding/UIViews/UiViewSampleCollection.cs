using UnityEngine;
using UnityEngine.UI;

public class UiViewSampleCollection : UIView
{
	[SerializeField]
	private Button _buttonAddItem;
	
	[SerializeField]
	private Button _buttonClear;

	[SerializeField]
	private Text _textCaption;
	
	[SerializeField] 
	private UICollectionItemView _collectionItemView;

	public Button ButtonAddItem { get { return _buttonAddItem; } }
	
	public Button ButtonClear { get { return _buttonClear; } }

	public Text TextCaption { get { return _textCaption; } }		

	public UICollectionItemView CollectionItemView { get { return _collectionItemView; } }
}
