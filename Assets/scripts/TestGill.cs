using UnityEngine;

public class TestGill : MonoBehaviour
{
	[SerializeField] InventoryWindow inv;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
		{
			inv.Redraw();
		}
    }
}
