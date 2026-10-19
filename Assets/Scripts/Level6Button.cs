using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level6Button : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] SceneConfig sceneConfig;

    [Header("Configurações de Áudio")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip SomDeAcerto;
    [SerializeField] OnClickDetectiveTalk onClickDetectiveTalk;

    public void Click()
    {
        if (sceneConfig.currentScene == 6)
        {
            onClickDetectiveTalk.WrongTalk();
        } else if (sceneConfig.currentScene == 8) {
            button.interactable = false;    
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            if (audioSource != null && SomDeAcerto != null)
            {
                audioSource.PlayOneShot(SomDeAcerto);
            }
        }
    }

}