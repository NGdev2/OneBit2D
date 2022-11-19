using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Items/keys")]
public class Item : ScriptableObject
{
	public string name = "Item";
	public Sprite Icon;

	public bool available;
}
