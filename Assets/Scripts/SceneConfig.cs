using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConfig : MonoBehaviour
{
    [SerializeField] HideScreen hideScreenVictory;
    [SerializeField] HideScreen hideScreenGeral;
    [SerializeField] HideScreen hideScreenButtons;

    private int pontos;    
    public int currentScene;

    public void AdicionarPonto()
    {
        // aumentando pontuação
        pontos++;
    }

    private void Start()
    {
        pontos = 0;
        
        // pegando qual é a cena atual para usarmos essa informação depois
        Scene cenaAtual = SceneManager.GetActiveScene();
        currentScene = cenaAtual.buildIndex;
    }

    private void Update()
    {
        // ponto onde a fase termina
        if (pontos >= 7)
        {
            hideScreenGeral.HideScreenTrue();
            hideScreenButtons.HideScreenTrue();
            // cutscene de vitória
            hideScreenVictory.ShowScreen();
        }
    }
}
