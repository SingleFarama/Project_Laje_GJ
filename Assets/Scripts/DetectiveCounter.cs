using System;
using System.Collections;
using UnityEngine;

public class DetectiveCounter : MonoBehaviour
{   
    private float tempoRestante = 10f;
    [SerializeField] AudioSource AudioSource;
    [SerializeField] private AudioClip toque1Relogio;
    [SerializeField] private AudioClip toque2Relogio;

    public IEnumerator Contador()
    {
        while (tempoRestante > 0f)
        {   
            // efeitos sonoros
            // efeito sonoro
            if ((i % 2) == 0)
            {
                AudioSource.PlayOneShot(toque1Relogio);
            } else
            {
                AudioSource.PlayOneShot(toque2Relogio);
            }

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
}
