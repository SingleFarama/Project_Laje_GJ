using System;
using System.Collections;
using UnityEngine;

public class DetectiveCounter : MonoBehaviour
{   
    private float tempoRestante = 10f;

    public IEnumerator Contador()
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
