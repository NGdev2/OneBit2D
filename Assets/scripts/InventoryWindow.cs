using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
	[SerializeField] RectTransform itemsPanel;

	public void Redraw(){
		for (var i = 0; i < targetInventory.inventoryItems.Count; i++) {
			if (targetInventory.inventoryItems[i].available == false) {
				continue;
			}
			var item = targetInventory.inventoryItems[i];
			var icon = new GameObject("Icon");
			icon.AddComponent<Image>().sprite = item.Icon;
			icon.transform.SetParent(itemsPanel);
		}
	}
}
