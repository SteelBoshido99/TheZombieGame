using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    public static bool AudioMute = false;

   


    public void Muter()
    {
        if (AudioMute)
        {
            Noise();
        }
        else
        {
            Silence();
        }
    }

    private void Silence()
    {
        AudioListener.pause = true;
    }

    private void Noise()
    {
        AudioListener.pause = false;
    }


}
