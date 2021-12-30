using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class helicopter : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //forward
        {
            transform.Translate(0, 0, 2);
        }

        if (Input.GetKey(KeyCode.DownArrow)) //backward
        {
            transform.Translate(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0.5f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.X)) //I want helicopter to fire bullet when x is pressed
        {
            Vector3 myposition = transform.position;

            myposition.y -= 20; 
            
            Instantiate(bullet, myposition, transform.rotation);
        }



    }
    private void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene("GameOver");
    }






    //__________________________________________________________//

    /* private void OnCollisionEnter(Collision collision)
     {
         print("collision!!!");

         if (!collision.gameObject.name.StartsWith("Terrain"))
         {
             Destroy(collision.gameObject); //it will destroy that game object which collides with helicopter
         }


    SceneManager.loadscene("GameOver");
     }

     private void OnTriggerEnter(Collider other) //it is used when you want to collide with the gameObject but 
                                                          //you also want to pass through it, make sure trigger is checked in the collider
     {
         print("Trigger!!!!!");
     }*/
}
