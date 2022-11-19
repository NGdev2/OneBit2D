using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideItems : MonoBehaviour
{
    public void HideChildren()
    {
		foreach(Transform child in transform)
		{
			child.gameObject.SetActive(false);
		}
    }
}
