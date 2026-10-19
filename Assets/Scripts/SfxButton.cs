using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SfxButton : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    [SerializeField] AudioSource music;

    [SerializeField] private Sprite imageOn;
    [SerializeField] private Sprite imageOff;
    [SerializeField] private int Level = 0;
    
    [SerializeField] Button button;
    [SerializeField] Image buttonImage;

    private bool isSfxOn = true;
    private bool canChangeAudio = true;

    private void Start()
    {
        if (Level == 5 || Level == 6 || Level == 7)
        {
            sfx.mute = false;
            music.mute = false;
            button.interactable = false;
            canChangeAudio = false;
        } else
        {
            canChangeAudio = true;
            button.interactable = true;
            isSfxOn = true;
        }

        MusicaVisualBotao(); 
    }

    public void ChangeOnOff()
    {
        if (canChangeAudio) {
        if (isSfxOn) 
        {
            isSfxOn = false;
        } else if (!isSfxOn)
        {
            isSfxOn = true;
        }

        MusicaVisualBotao();
        }
    }

    private void MusicaVisualBotao()
    {
        if (isSfxOn) 
        {
            buttonImage.sprite = imageOn;
            sfx.mute = false;
            music.mute = false;
        } else if (!isSfxOn)
        {
            buttonImage.sprite = imageOff;
            sfx.mute = true;
            music.mute = true;
        }
    
    }
}
