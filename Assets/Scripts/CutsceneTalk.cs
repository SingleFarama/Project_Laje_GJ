using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class CutsceneTalk : MonoBehaviour
{
    // variáveis para o inspetor do unity
    [SerializeField] SceneConfig sceneConfig;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    private string[] frases;
    private string proximaCena;
    private void Start()
    {
        StartCoroutine(RodarFrases());
    }
    public IEnumerator RodarFrases()
    {
        

        // definindo as frases de acordo com a cena
        if (sceneConfig.currentScene == 1) // cutscene do início
        {
            frases = new [] {
                "Olá! Meu nome é Detetive",
                "Tenho um desafio pra você",
                "Vou te mostrar uma imagem...", 
                "e você precisará memorizar todos os elementos dela",
                "Depois, eu vou tirar 7 elementos dessa imagem...",
                "e você precisará achar os 7 erros",
                "Será que você consegue?!"
            };
            proximaCena = "Level_1";
        } else if (sceneConfig.currentScene == 3) // cutscene do final
        {
            frases = new[]
            {
                "Parabéns! Você conseguiu achar todos os erros!!!",
                "Aposto que você se tornará um grande detetive como eu!!!",
                "...",
                "Por favor...",
                "Não deixe de jogar esse jogo..."
            };
            proximaCena = "StartScene";
        }
        for (int i = 0; i < frases.Length; i++) // loop para mostrar as frases na tela
        {
            // mudando o texto
            textMeshProUGUI.text = frases[i];
            
            // indo para a próxima frases (se tiver)

            yield return new WaitForSeconds(2.5f); // esperar por 5 segundos
        }

        SceneManager.LoadScene(proximaCena);
    
    }
}
