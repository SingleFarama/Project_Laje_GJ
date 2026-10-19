using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    [Header("Configurações de Áudio")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip SomDeAcerto;
    public void OnClick(){
        // mudando de cena
        if (audioSource != null && SomDeAcerto != null)
        {
            audioSource.PlayOneShot(SomDeAcerto);
        }
        SceneManager.LoadScene("Credits");
    }
}
