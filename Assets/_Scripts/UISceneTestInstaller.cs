using UnityEngine;
using Zenject;
 
public class UISceneTestInstaller : MonoInstaller<UISceneTestInstaller>
{
    [Inject] private UISceneSettingsInstaller.UIPrefabs _uiPrefabs;
    public override void InstallBindings()
    {
        Debug.Log("[UISceneTestInstaller] InstallBindings");                
        Container.BindViewController<UiViewSampleWindow, UiControllerUiSampleWindow>(_uiPrefabs.StartGameView);
        Container.BindViewController<UiViewSampleCollection, UiControllerUiSampleCollection>(_uiPrefabs.SampleCollectionView);
    }    
}
