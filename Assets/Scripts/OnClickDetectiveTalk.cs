using UnityEngine;

public class OnClickDetectiveTalk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int indiceFraseAtual = 0; // índice inicial = frase inicial

    public void OnClick(string[] frases)
    {
        int quantidade_frases = frases.Length;

        // mudando o texto
        // TextUI = frases[indiceFraseAtual]

        // próxima frase (se possível)
        if (indiceFraseAtual <= quantidade_frases)
        {
            indiceFraseAtual++; // índice da próxima frase
        }

    }
}
