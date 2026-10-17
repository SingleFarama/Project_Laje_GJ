using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConfig : MonoBehaviour
{
    WinScreen winScreen;

    private int pontos;
    private int CenaAtual;

    public void AdicionarPonto()
    {
        pontos++;
    }

    private void Start()
    {
        pontos = 0;

        Scene cenaAtual = SceneManager.GetActiveScene();
        CenaAtual = cenaAtual.buildIndex;
    }

    private void Update()
    {
        if (pontos >= 7)
        {
            StartCutscene();
        }
    }

    private void StartCutscene()
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
