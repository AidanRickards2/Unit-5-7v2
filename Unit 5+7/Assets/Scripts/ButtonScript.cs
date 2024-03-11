using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    AudioManager audioManager;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void OnClick()
    {
        audioManager.PlaySFX(audioManager.Beep);
    }

    public void StartNoise()
    {
        audioManager.PlayFly(audioManager.Fly);
    }
}
