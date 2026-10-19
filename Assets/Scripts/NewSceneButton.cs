using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [Header("Configurações de Áudio")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip SomDeAcerto;
	public void NextScene()
	{	
		if (audioSource != null && SomDeAcerto != null)
        {
            audioSource.PlayOneShot(SomDeAcerto);
        }
		// passando para a próxima cena
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
