using UnityEngine;

public class HideScreen : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroupVictory; 

    public void ShowScreen()
    {
        if (canvasGroupVictory != null)
        {
            canvasGroupVictory.alpha = 0.8f;    
            canvasGroupVictory.interactable = true;  
            canvasGroupVictory.blocksRaycasts = true; 
        }
    }

    public void HideScreenTrue()
    {
        if (canvasGroupVictory != null)
        {
            canvasGroupVictory.alpha = 0f;
            canvasGroupVictory.interactable = false;
            canvasGroupVictory.blocksRaycasts = false;
        }
    }
}