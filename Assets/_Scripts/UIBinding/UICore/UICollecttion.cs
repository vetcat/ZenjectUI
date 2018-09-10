using System.Collections.Generic;
using UnityEngine;

public abstract class UICollecttion<TMono, TView> : MonoBehaviour where TMono : UICollecttion<TMono, TView> where TView: UIView
{
    [SerializeField] 
    private Transform _collectionRoot;

    [SerializeField] 
    private TView _collectionPrefab;

    private readonly List<TView> _items = new List<TView>();

    public TView AddItem()
    {
        TView item = Instantiate(_collectionPrefab, _collectionRoot).GetComponent<TView>();
        _items.Add(item);
        return item;
    }
        
    public IEnumerable<TView> GetItems()
    {
        return _items;
    }

    public void Clear()
    {
        foreach (var item in _items)            
            Destroy(item.gameObject);
        
        _items.Clear();
    }

    public int Count()
    {
        return _items.Count;
    }
}
