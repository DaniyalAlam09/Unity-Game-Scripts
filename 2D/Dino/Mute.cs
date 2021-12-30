using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    [SerializeField] GameObject Mutebtn;
    [SerializeField] GameObject unMutebtn;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mute(){
        audio.mute= true;
        unMutebtn.SetActive(true);
        Mutebtn.SetActive(false);
    }
    public void unmute(){
       audio.mute= false;
       Mutebtn.SetActive(true);
       unMutebtn.SetActive(false);
    }
    public void Awake()
    {
        // Mutebtn.SetActive(false);
        unMutebtn.SetActive(false);
        
         //hide menu in the start
    }
}
