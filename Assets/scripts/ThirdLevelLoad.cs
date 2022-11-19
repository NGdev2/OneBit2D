using UnityEngine.SceneManagement;
using UnityEngine;

public class ThirdLevelLoad : MonoBehaviour
{
    public void loadThirdLevel()
	{
		SceneManager.LoadScene("Level_3");
	}
}
