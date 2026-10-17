using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
	public void NextScene()
	{	
		// passando para a próxima cena
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
