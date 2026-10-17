using UnityEngine;
using UnityEngine.UI;

public class MudarImagem : MonoBehaviour
{
    [SerializeField] private Image componenteImagem; 
    [SerializeField] private Sprite novaImagem; 

    public void AlterImage()
    {
        if (componenteImagem != null && componenteImagem != null)
        {
            componenteImagem.sprite = novaImagem; 
        }
    }
}
