using UnityEngine;

public class UIView : MonoBehaviour
{
    protected virtual GameObject GameObject
    {
        get { return gameObject; }
    }
    
    public virtual void Show(bool isShow = true)
    {
        GameObject.SetActive(isShow);
    }
    
    public virtual void Hide()
    {
        GameObject.SetActive(false);
    }
    
    public virtual bool IsShow()
    {
        return GameObject.activeInHierarchy;
    }
}
