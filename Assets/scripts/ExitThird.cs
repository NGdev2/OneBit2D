using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitThird : MonoBehaviour
{
	// private IEnumerator coroutine;
	public GameObject warningText;
	public uint coins_needed = 25;
	public Show_score score_script;
	
	public GameObject winFrame;
    private void OnTriggerEnter2D(Collider2D other) {
		
		if (score_script.TakeCoins() >= coins_needed)
		{
			Win();
		}
		else{
			
			warningText.SetActive(true);
			StartCoroutine(hideWarningText());
		}
	}

	IEnumerator hideWarningText()
    {
		yield return new WaitForSeconds(2f);
		warningText.SetActive(false);
    }

	public void Win(){
		if (winFrame != null)
		{
			winFrame.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
