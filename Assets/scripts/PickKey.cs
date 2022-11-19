using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
	public string keyName;
	[SerializeField] Inventory personInventory;
	[SerializeField] InventoryWindow inv;
	[SerializeField] HideItems hider;

	private void OnTriggerEnter2D(Collider2D other)
	{
		Item itemKey = personInventory.inventoryItems.Find(x => x.name == keyName);
		hider.HideChildren();
		itemKey.available = true;
		inv.Redraw();
		gameObject.SetActive(false);
	}
}
