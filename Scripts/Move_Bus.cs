using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Bus : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource horn;
    void Start()
    {
        
    }

   // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 20);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 2, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -2, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -20);
        }
        if(Input.GetKey(KeyCode.Space)){
            Rigidbody r = GetComponent<Rigidbody>();
            r.AddForce(0, 15, 0);
        }
        if (Input.GetKeyDown(KeyCode.H)){
            horn.Play();
        }


}
}
