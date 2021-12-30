using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
    // Start is called before the first frame update
    Animator myAnimator;
    private GameObject me;
    void Start()
    {
         me= GameObject.Find("MP7");
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("iswalk", true);
        myAnimator.SetBool("isdead", false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.0000001f);
        transform.LookAt(me.transform);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.StartsWith("Bullet")){
            print("enemy hit");
            myAnimator.SetBool("iswalk", false);
            myAnimator.SetBool("isdead", true);
     }
    }
}
