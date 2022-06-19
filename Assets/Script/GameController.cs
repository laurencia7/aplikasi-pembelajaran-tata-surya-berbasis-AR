using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject PanelInfoo;
    public AudioSource PlaySound;

    public bool show = false;

    public void ShowHideInfo()
    {
        if(!show)
        {
            PanelInfoo.SetActive(true);
            show = true;
        }
        else
        {
            PanelInfoo.SetActive(false);
            show = false;
        }
    }

    public void PlaySoundInfo()
    {
        PlaySound.Play();
    }
}
