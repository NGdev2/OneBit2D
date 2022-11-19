using UnityEngine;

public class TakeCoin : MonoBehaviour
{
	public Show_score score_script;
	private void OnTriggerEnter2D(Collider2D other)
    {
		if (score_script == null)
		{
			return;
		}
		gameObject.SetActive(false);
		score_script.Calculate();
    }
}
