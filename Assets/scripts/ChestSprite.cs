using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSprite : MonoBehaviour
{
	[SerializeField] Inventory personInventory;
	[SerializeField] InventoryWindow inv;
	[SerializeField] HideItems hider;
	public Show_score score_script;
    public Sprite[] sprites = new Sprite[2];
	private bool is_open = false;
	public string chestName;

	public void OpenChest()
	{
		if (is_open == true ||
		score_script == null || hider == null || inv == null || personInventory == null) {
			return;
		}
		var keyName = chestName + "Key";
		Item itemKey = personInventory.inventoryItems.Find(x => x.name == keyName);
		if (itemKey.available == false){
			return;
		}
		this.is_open = true;
		gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
		score_script.Calculate(10);
		hider.HideChildren();
		inv.Redraw();
	}

	private void OnTriggerEnter2D(Collider2D other) {
		OpenChest();
	}
}
