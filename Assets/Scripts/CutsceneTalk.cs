using UnityEngine;
using System.Collections;

public class CutsceneTalk : MonoBehaviour
{
    public int indiceFrase = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RodarFrases(string[] frases)
    {
        int quantidadeFrases = frases.Length;

        // mudando o texto
        // textoUI = frases[indiceFrase]

        // indo para a próxima frases (se tiver)
        if (indiceFrase < quantidadeFrases)
        {
            indiceFrase++;
        }
        
        yield return new WaitForSeconds(5f); // esperar por 5 segundos
    }
}
