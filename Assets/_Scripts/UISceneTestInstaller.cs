using UnityEngine;
using Zenject;
 
public class UISceneTestInstaller : MonoInstaller<UISceneTestInstaller>
{
    [Inject] private UISceneSettingsInstaller.UIPrefabs _uiPrefabs;
    public override void InstallBindings()
    {
        Debug.Log("[UISceneTestInstaller] InstallBindings");                
        Container.BindViewController<ViewSampleWindow, ControllerUISampleWindow>(_uiPrefabs.StartGameView);
        Container.BindViewController<ViewSampleCollection, ControllerUISampleCollection>(_uiPrefabs.SampleCollectionView);
    }    
}
