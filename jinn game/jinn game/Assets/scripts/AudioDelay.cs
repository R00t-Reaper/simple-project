using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDelay : MonoBehaviour


{
public float timer = 2.0f; // the timer
    AudioSource myaudio;
    // Start is called before the first frame update
    void Start()
    {
        
        myaudio = GetComponent<AudioSource>();
        Invoke("playAudio",timer);

    }

    void playAudio()
    {
        myaudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
