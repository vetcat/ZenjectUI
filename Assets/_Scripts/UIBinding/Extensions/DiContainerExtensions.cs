using UnityEngine;
using Zenject;

public static class DiContainerExtensions
{
    public static void BindController<TController>(this DiContainer container)
        where TController : Controller
    {
        container.BindInterfacesAndSelfTo<TController>().AsSingle().NonLazy();
    }

    public static void BindViewController<TView, TController>(this DiContainer container, GameObject viewPrefab)
        where TView : View
        where TController : Controller
    {     
        container.Bind<TView>().FromComponentInNewPrefab(viewPrefab).AsSingle();
        container.BindController<TController>();
    }
}
