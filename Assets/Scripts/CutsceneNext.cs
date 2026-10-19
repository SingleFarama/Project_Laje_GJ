using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CutsceneNext : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CenaFinal());
    }
    private IEnumerator CenaFinal()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}