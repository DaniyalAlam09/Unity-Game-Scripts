using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public GameObject mute, unmute;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        mute.SetActive(true);
        unmute.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuteFucntion() {
        audio.Pause();
        mute.SetActive(false);
        unmute.SetActive(true);
    }

    public void UnmuteFucntion()
    {
        audio.Play();
        mute.SetActive(true);
        unmute.SetActive(false);
    }
}
