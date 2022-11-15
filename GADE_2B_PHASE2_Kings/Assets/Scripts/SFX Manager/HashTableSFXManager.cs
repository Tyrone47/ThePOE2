using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableSFXManager : MonoBehaviour
{
    public Hashtable PlaySFX;
    public Hashtable AudioSource;

    public AudioSource as1;
    public AudioSource as2;
    public AudioSource as3;
    public AudioSource as4;
    public AudioSource as5;

    

    void Start()
    {
        PlaySFX = new Hashtable();
        
        PlaySFX.Add(1, "Click");
        PlaySFX.Add(2, "");
        PlaySFX.Add(3, "");
        PlaySFX.Add(4, "");
        PlaySFX.Add(5, "");




        Dictionary<int, AudioSource> audioSources = new Dictionary<int, AudioSource>();
        audioSources.Add(1, as1);
        audioSources.Add(2, as2);
        audioSources.Add(3, as3);
        audioSources.Add(4, as4);
        audioSources.Add(5, as5);
        AudioSource = new Hashtable(audioSources);

    }
    public void SFXPlayer()
    {
        as1.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            as2.Play();
        }
    }



}
