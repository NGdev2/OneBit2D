using System;
using UnityEngine;
using UnityEngine.UI;

public class Show_score : MonoBehaviour
{
	[System.NonSerialized] static public uint score = 0;
	// [SerializeField] private string[] keys = new string[3];
	private string text = "Score: ";
	public Text textObj;
	// public static DateTime timer;
	// public static Int64 timer;

    void Start()
    {
        textObj.text = text + score;
		// TODO: make correct time display
		// timer = System.DateTime.Now.Second;
		// timer = TimeSpan.FromTicks(DateTime.Now.Ticks).TotalSeconds;
		// timer = DateTime.Now.Ticks;
    }

	public void Calculate(uint amount = 1)
	{
		score += amount;
		textObj.text = text + score;
	}

	public uint TakeCoins(){
		return score;
	}
}
