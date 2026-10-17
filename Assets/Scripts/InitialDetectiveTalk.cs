using System.Collections;
using UnityEngine;


public class InitialDetectiveTalks : MonoBehaviour
{   

    public IEnumerator FraseInicial(string frase)
    {
        // mudando o texto
        // TextoUI = frase

        yield return new WaitForSeconds(5f);
    }
}
