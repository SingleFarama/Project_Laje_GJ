using UnityEngine;
using UnityEngine.UI;

public class FindError : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] SceneConfig sceneConfig;
    [SerializeField] Image image;

    [Header("Configurações de Áudio")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip somDoClique;

    public void Find()
    {
        button.interactable = false;    
        sceneConfig.AdicionarPonto();
        image.color = Color.white;

        if (audioSource != null && somDoClique != null)
        {
            audioSource.PlayOneShot(somDoClique);
        }
    }
}