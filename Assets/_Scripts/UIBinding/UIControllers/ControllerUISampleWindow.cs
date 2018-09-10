using UnityEngine;
using Zenject;

public class ControllerUISampleWindow : Controller<ViewSampleWindow>
{
    [Inject] private ControllerUISampleCollection _controllerUiSampleCollection;
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
        _controllerUiSampleCollection.View.Show(!_controllerUiSampleCollection.View.IsShow()); 
    }
}
