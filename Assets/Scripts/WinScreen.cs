using System;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroupVictory; 

    private void Start()
    {
        if (canvasGroupVictory != null)
        {
            HideVictoryScreen();
        }
    }

    public void ShowVictoryScreen()
    {
        if (canvasGroupVictory != null)
        {
            canvasGroupVictory.alpha = 0.8f;    
            canvasGroupVictory.interactable = true;  
            canvasGroupVictory.blocksRaycasts = true; 
        }
    }

    private void HideVictoryScreen()
    {
        if (canvasGroupVictory != null)
        {
            canvasGroupVictory.alpha = 0f;
            canvasGroupVictory.interactable = false;
            canvasGroupVictory.blocksRaycasts = false;
        }
    }
}