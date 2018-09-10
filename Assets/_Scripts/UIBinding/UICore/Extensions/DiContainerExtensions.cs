using UnityEngine;
using Zenject;

public static class DiContainerExtensions
{
    public static void BindController<TController>(this DiContainer container)
        where TController : UIController
    {
        container.BindInterfacesAndSelfTo<TController>().AsSingle().NonLazy();
    }

    public static void BindViewController<TView, TController>(this DiContainer container, GameObject viewPrefab)
        where TView : UIView
        where TController : UIController
    {     
        container.Bind<TView>().FromComponentInNewPrefab(viewPrefab).AsSingle();
        container.BindController<TController>();
    }
}
