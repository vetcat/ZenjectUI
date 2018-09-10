using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UICollection : MonoBehaviour 
{
    [SerializeField] 
    private Transform _collectionRoot;

    [SerializeField] 
    private GameObject _collectionPrefab;

    private readonly List<View> _items = new List<View>();

    public View AddItem()
    {
        View item = Instantiate(_collectionPrefab, _collectionRoot).GetComponent<View>();
        _items.Add(item);
        return item;
    }
        
    public IEnumerable<View> GetItems()
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
