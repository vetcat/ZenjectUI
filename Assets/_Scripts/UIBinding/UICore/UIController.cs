using System;
using Zenject;

public abstract class UIController : IInitializable, IDisposable
{
    public virtual void Initialize()
    {        
    }

    public virtual void Dispose()
    {        
    }
}

public abstract class UiController<T> : UIController
    where T : UIView
{
    [Inject]
    private T _view;

    public T View { get { return _view; } }
}