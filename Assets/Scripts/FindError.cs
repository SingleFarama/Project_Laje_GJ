using UnityEngine;
using UnityEngine.UI;

public class FindError : MonoBehaviour
{
    public Button button; 
    SceneConfig sceneConfig;

    [SerializeField] Image imagemDoBotao;
    
    [Header("Configurações de Áudio")]
    AudioSource audioSource;
    [SerializeField] AudioClip somDoClique;

    public void OnClick()
    {
        button.interactable = false;    
        sceneConfig.AdicionarPonto();

        Color corAtual = imagemDoBotao.color;
        corAtual.a = 1f;
        imagemDoBotao.color = corAtual;


        if (audioSource != null && somDoClique != null)
        {
            audioSource.PlayOneShot(somDoClique);
        }
    }
}