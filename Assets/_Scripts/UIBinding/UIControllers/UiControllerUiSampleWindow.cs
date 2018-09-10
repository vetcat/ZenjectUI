using UnityEngine;
using Zenject;

public class UiControllerUiSampleWindow : UiController<UiViewSampleWindow>
{
    [Inject] private UiControllerUiSampleCollection _uiControllerUiSampleCollection;
    public override void Initialize()
    {
        View.Show();

        View.TextCaption.text = "Press button to show / hide Collection Window";
     
        View.ButtonShowHideCollectionWindow.onClick.AddListener(ShowHideCollection);
    }

    public override void Dispose()
    {        
        View.ButtonShowHideCollectionWindow.onClick.RemoveListener(ShowHideCollection);
    }    

    private void ShowHideCollection()
    {
        Debug.Log("[ControllerUISampleWindow] ShowHideCollection");
        _uiControllerUiSampleCollection.View.Show(!_uiControllerUiSampleCollection.View.IsShow()); 
    }
}
