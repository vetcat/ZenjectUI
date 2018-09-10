using UnityEngine;

public class ControllerUISampleCollection : Controller<ViewSampleCollection>
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

        foreach (var item in View.Collection.GetItems())
        {
            ItemView itemView = (ItemView) item;
            itemView.ButtonSelect.onClick.RemoveAllListeners();            
        }
    }
    
    private void AddItem()
    {
        int curentCount = View.Collection.Count() + 1;
        Debug.Log("[ControllerUISampleCollection] AddItem  " + curentCount);     
        
        ItemView item = (ItemView) View.Collection.AddItem();
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
        View.Collection.Clear();
    }
}
