using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuButton : MonoBehaviour
{   
    public void OnClick()
    {
        SceneManager.LoadScene("StartScene");
    }
}
