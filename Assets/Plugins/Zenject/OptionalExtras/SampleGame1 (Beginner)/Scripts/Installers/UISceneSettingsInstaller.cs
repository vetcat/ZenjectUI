using System;
using UnityEngine;
using Zenject;

[CreateAssetMenu(menuName = "Scriptable/UISceneSettings")]
public class UISceneSettingsInstaller : ScriptableObjectInstaller<UISceneSettingsInstaller>
{
    [Serializable]
    public class UIPrefabs
    {
        public GameObject StartGameView;
        public GameObject SampleCollectionView;
    }

    public UIPrefabs UIPrefabsInstace;
    
    public override void InstallBindings()
    {
         Debug.Log("[UISceneSettingsInstaller] InstallBindings");
        Container.BindInstance(UIPrefabsInstace);
    }
}

