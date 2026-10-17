using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    SceneConfig sceneConfig;

    [SerializeField] Image imagemDoBotao;
    
    private void Start()
    {
        Color corAtual = imagemDoBotao.color;
        corAtual.a = 0f;
        imagemDoBotao.color = corAtual;
    }

    public void Show()
    {
        
    }

}
