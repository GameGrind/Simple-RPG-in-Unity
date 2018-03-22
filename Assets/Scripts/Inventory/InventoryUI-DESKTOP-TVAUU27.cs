using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour {
    public RectTransform inventoryPanel;
    public RectTransform scrollViewContent;

    InventoryUIItem itemContainer { get; set; }
    List<InventoryUIItem> itemUIList = new List<InventoryUIItem>();
    bool menuIsActive { get; set; }
    Item currentSelectedItem { get; set; }
	// Use this for initialization
	void Start () {
        UIEventHandler.OnItemAddedToInventory += ItemAdded;
        itemContainer = Resources.Load<InventoryUIItem>("UI/Item_Container");
        inventoryPanel.gameObject.SetActive(false);
	}
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            menuIsActive = !menuIsActive;
            inventoryPanel.gameObject.SetActive(menuIsActive);
        }
    }

    public void ItemAdded(Item item)
    {
       InventoryUIItem emptyItem = Instantiate(itemContainer);
       emptyItem.SetItem(item);
       itemUIList.Add(emptyItem);
       emptyItem.transform.SetParent(scrollViewContent);
    }
}
