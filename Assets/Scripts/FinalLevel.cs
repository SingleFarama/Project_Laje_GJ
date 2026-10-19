using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalLevel : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CenaFinal());
    }
    private IEnumerator CenaFinal()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
