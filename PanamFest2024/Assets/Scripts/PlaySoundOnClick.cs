using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnClick : MonoBehaviour
{
    public void PlaySound(string soundName)
    {
        AudioManager.Instance.Play(soundName);
    }
}
