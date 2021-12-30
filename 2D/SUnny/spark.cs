using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spark : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
        anim.SetBool  ("frogDead" , false);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name.StartsWith("Squirrel")){
            anim.SetBool  ("frogDead" , true);
        }
        Destroy(collision.transform.gameObject);
        anim.SetBool  ("frogDead" , false);
}
}
