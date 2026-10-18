using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{

    public void OnClick(){
        // mudando de cena
        SceneManager.LoadScene("Credits");
    }
}
