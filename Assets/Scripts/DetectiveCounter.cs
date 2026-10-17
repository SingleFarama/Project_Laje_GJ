using System;
using System.Collections;
using UnityEngine;

public class DetectiveCounter : MonoBehaviour
{   
    public float tempoRestante = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Contador());
    }
    IEnumerator Contador()
    {
        while (tempoRestante > 0f)
        {
            // vou ter que mudar a malha de texto aqui
            // textoUI.text = tempo

            // tempo de espera
            yield return new WaitForSeconds(1f); // espere 1 segundo

            // atualização do tempo restante
            tempoRestante--; 
        }

        // talvez colocar um texto final quando acabar o tempo
        // textoUI.text = "Vamos!"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
