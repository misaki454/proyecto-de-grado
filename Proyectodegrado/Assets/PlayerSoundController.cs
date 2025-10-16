using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundController : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip sonidoSaltar;  
    public AudioClip sonidoCaida; 
    public AudioClip sonidoMov1; 
    public AudioClip sonidoMov2;

    public void playSaltar()
    {
        audioSource.PlayOneShot(sonidoSaltar);
    }

    public void playCaida()
    {
        audioSource.PlayOneShot(sonidoCaida);
    }

    public void playMov1()
    {
        audioSource.PlayOneShot(sonidoMov1);
    }

    public void playMov2()
    {
        audioSource.PlayOneShot(sonidoMov2);
    }
}