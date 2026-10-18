using UnityEngine;
using UnityEngine.UI;

public class FindError : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] SceneConfig sceneConfig;
    [SerializeField] Image image;

    [Header("Configurações de Áudio")]
    AudioSource audioSource;
    [SerializeField] AudioClip SomDeAcerto;

    public void Find()
    {
        button.interactable = false;    
        sceneConfig.AdicionarPonto();
        image.color = Color.white;

        if (audioSource != null && SomDeAcerto != null)
        {
            audioSource.PlayOneShot(SomDeAcerto);
        }
    }
}