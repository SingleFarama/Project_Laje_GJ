using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OnClickDetectiveTalk : MonoBehaviour
{
    [SerializeField] SceneConfig sceneConfig;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] Button button;
    [SerializeField] MudarImagem mudarImagem;
    [SerializeField] HideScreen hideScreen;

    private string[] frases; 
    private string falaInicial;
    private int indiceFraseAtual = 0; // índice inicial = frase inicial

    private void Start()
    {
        CharacterWords();
        StartCoroutine(SequenciaInicial());
        button.interactable = false;
    }

    public void OnClick()
    {
        if (frases == null || frases.Length == 0) return;

        int quantidade_frases = frases.Length;

        textMeshProUGUI.text = frases[indiceFraseAtual];
        indiceFraseAtual++; // índice da próxima frase
        
        if (indiceFraseAtual >= quantidade_frases)
        {
            indiceFraseAtual = 0;
        }

    }
    
    private IEnumerator SequenciaInicial()
    {
        textMeshProUGUI.text = falaInicial;
        yield return new WaitForSeconds(1.5f);

        for (int i = 7; i > 0; i--)
        {
            textMeshProUGUI.text = i.ToString(); 
            yield return new WaitForSeconds(1f);
        }

        button.interactable = true;

        mudarImagem.AlterImage();
        hideScreen.ShowScreen();

        textMeshProUGUI.text = frases[0];
        indiceFraseAtual++;
    }

    #region DETETIVE

    private void CharacterWords()
    {
        if (sceneConfig.currentScene <= 2)
        {
            falaInicial = "Se prepare...";
            frases = new[] { "Vamos encontrar os erros juntos!", 
                                "Já procurou naquele vaso?", 
                                "Minha lupa está encontrando algo!", 
                                "Eu acho que tinha um chapéu naquele janela..." 
                              };
        } if (sceneConfig.currentScene == 2)
        {
            
        } if (sceneConfig.currentScene == 3)
        {
            
        } if (sceneConfig.currentScene == 4)
        {
            
        } if (sceneConfig.currentScene == 5)
        {
            
        } if (sceneConfig.currentScene == 6)
        {
            
        } if (sceneConfig.currentScene == 7)
        {
            
        } else
        {
            
        }
        
    }
#endregion
}