using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip death;
    public AudioClip walking;
    public AudioClip takingMushroom;


    private void Start()
    {

        musicSource.clip = background;
        musicSource.Play();
    }
}
