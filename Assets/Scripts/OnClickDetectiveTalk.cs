using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClickDetectiveTalk : MonoBehaviour
{
    [SerializeField] SceneConfig sceneConfig;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] Button button;
    [SerializeField] MudarImagem mudarImagem;
    [SerializeField] HideScreen hideScreen;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip somMudancaFrase;

    private string[] frases; 
    private string falaInicial;
    private int indiceFraseAtual = 0; // índice inicial = frase inicial
    private bool NextLevel;

    private void Start()
    {
        CharacterWords();
        StartCoroutine(SequenciaInicial());
        button.interactable = false;
    }

    public void OnClick()
    {
        if (!NextLevel) {
        if (frases == null || frases.Length == 0) return;

        int quantidade_frases = frases.Length;

        textMeshProUGUI.text = frases[indiceFraseAtual];
        indiceFraseAtual++; // índice da próxima frase
        audioSource.PlayOneShot(somMudancaFrase);
        
        if (indiceFraseAtual >= quantidade_frases)
        {
            indiceFraseAtual = 0;
        }
        } else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    public void WrongTalk()
    {
        textMeshProUGUI.text = "Seu bobinho! Não tem nada de errado aí. Tente novamente!";
        NextLevel = true;
    }

    private void CharacterWords()
    {
        if (sceneConfig.currentScene <= 3)
        {
            falaInicial = "Se prepare...";
            frases = new[] { "Você pode apertar em min para conversar! Eu também dou dicas!",
                                "Vamos encontrar os erros juntos!", 
                                "Já procurou naquele vaso?", 
                                "Minha lupa está encontrando algo!", 
                                "Eu acho que tinha um chapéu naquele janela..." 
                              };
        } if (sceneConfig.currentScene == 4)
        {
            falaInicial = "Gostou?";
            frases = new[] { "Não tinha uma musica sobre patinhos?", 
                                "Quantos eram mesmo?", 
                                "Não eram tantos, né?", 
                                "Me pergunto onde está mãe deles." 
                              };
            
        } if (sceneConfig.currentScene == 5)
        {
            falaInicial = "Você é incrível!";
            frases = new[] { "Já vimos isso antes!", 
                                "Me parece um pouco diferente.", 
                                "Antes estava mais bonito.", 
                                "Você não acha que estamos com menos agora?",
                                "-Por favor! Continue procurando até encontrar os erros!!",
                                "Não pare de tentar!!!",
                                "Eu preciso que você encontre os erros",
                                "Não está tão difícil, eu sei que você consegue achá-los!",
                                "Você realmente está tentando?",
                                "Eu não acredito que isso é você tentando!" 
                              };
        } if (sceneConfig.currentScene == 6)
        {
            falaInicial = "Está cansado?";
            frases = new[] { "Não há nada de errado?", 
                                "Já achou o erro?", 
                                "Você não gosta do que está vendo?", 
                                "Você lembra desse lugar?" 
                              };
        } if (sceneConfig.currentScene == 7)
        {
            falaInicial = "yield return new WaitForSeconds(1f);";
            frases = new[] { "aljfnjfnasdnfãsnfm3~rj9-9", 
                                "!#+)K!_F#_MC!CIM{@C!M_{C_SAA}}", 
                                "ew fefewf231-9 -m m31 3qg", 
                                "13jf´  2féfméwdf as AS ~dASP D ",
                                "!_#J(_$sfldmfwem24o32**&*#!4" 
                              };
        } if (sceneConfig.currentScene == 8)
        {
            falaInicial = "Se prepare...";
            frases = new[] { "", 
                                "", 
                            };
        }

    }
}
#endregion
