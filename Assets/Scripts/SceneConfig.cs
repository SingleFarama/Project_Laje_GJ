using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConfig : MonoBehaviour
{
    WinScreen winScreen;

    private int pontos;
    private int CenaAtual;

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
        CenaAtual = cenaAtual.buildIndex;
    }

    private void Update()
    {
        // ponto onde a fase termina
        if (pontos >= 7)
        {
            // cutscene de vitória
            StartCutscene();
        }
    }

    private void StartCutscene() // cutscene de vitória
    {

        CharacterTalk();
        WinScreen();
    }

    private void WinScreen()
    {
        winScreen.Show();
    }

#region BONEQUINHO

    private void CharacterTalk()
    {
        if (CenaAtual == 1)
        {
            
        } if (CenaAtual == 2)
        {
            
        } if (CenaAtual == 3)
        {
            
        } if (CenaAtual == 4)
        {
            
        } if (CenaAtual == 5)
        {
            
        } if (CenaAtual == 6)
        {
            
        } if (CenaAtual == 7)
        {
            
        } else
        {
            
        }
        
    }
#endregion
}
