using UnityEngine;

public class UiControllerUiSampleCollection : UiController<UiViewSampleCollection>
{        
    public override void Initialize()
    {        
        View.Hide();
        View.TextCaption.text = "Sample Collection";     
        View.ButtonAddItem.onClick.AddListener(AddItem);
        View.ButtonClear.onClick.AddListener(ClearItems);
    }

    public override void Dispose()
    {     
        View.ButtonAddItem.onClick.RemoveListener(AddItem);
        View.ButtonClear.onClick.RemoveListener(ClearItems);

        foreach (var item in View.CollectionItemView.GetItems())
        {
            ItemView itemView = (ItemView) item;
            itemView.ButtonSelect.onClick.RemoveAllListeners();            
        }
    }
    
    private void AddItem()
    {
        int curentCount = View.CollectionItemView.Count() + 1;
        Debug.Log("[ControllerUISampleCollection] AddItem  " + curentCount);     
        
        ItemView item = View.CollectionItemView.AddItem();
        item.Caption.text = "Number: " + curentCount;
        //todo: id поле для примера - поля могут быть любые например id пака в магазине
        item.Id = curentCount;
        item.ButtonSelect.onClick.AddListener(() => { ItemButtonPressed(item); });
    }

    private void ItemButtonPressed(ItemView item)
    {
        Debug.Log("[ControllerUISampleCollection] ItemButtonPressed  " + item.Id);        
    }
    
    private void ClearItems()
    {
        Debug.Log("[ControllerUISampleCollection] ClearItems");
        View.CollectionItemView.Clear();
    }
}
