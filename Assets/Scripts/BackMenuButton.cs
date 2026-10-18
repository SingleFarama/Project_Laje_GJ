using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuButton : MonoBehaviour
{   
    //[SerializeField] private AudioSource AudioSource;
    //[SerializeField] private AudioClip SomBotaoUI;
    public void OnClick()
    {   
        //AudioSource.PlayOneShot(SomBotaoUI);

        // trocando de cena
        SceneManager.LoadScene("StartScene");
    }
}
