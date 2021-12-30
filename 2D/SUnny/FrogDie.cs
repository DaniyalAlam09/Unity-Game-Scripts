using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogDie : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool  ("frogDead" , false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     private void OnCollisionEnter2D(Collision2D collision){
         if (collision.gameObject.name.StartsWith("Squirrel"))
        {
             anim.SetBool  ("frogDead" , true);
             Destroy(transform.gameObject);
        }
        
        anim.SetBool  ("frogDead" , false);
     }
}
