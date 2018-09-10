using System;
using Zenject;

public abstract class Controller : IInitializable, IDisposable
{
    public virtual void Initialize()
    {        
    }

    public virtual void Dispose()
    {        
    }
}

public abstract class Controller<T> : Controller
    where T : View
{
    [Inject]
    private T m_view = null;

    public T View { get { return m_view; } }
}