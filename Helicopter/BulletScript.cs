using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public GameObject explosion;
    public Text scoreText; //this is the text that has been placed in game scene as scoreText

    public static float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1);
        explosion.SetActive(false); //it will hide the gameObject
    }

    private void OnCollisionEnter(Collision col)
    {
        if (!col.gameObject.name.StartsWith("Terrain"))
        {
            Destroy(col.gameObject); //it will destroy the object with which bullet will collide
            score += 10; //thats your own rule to increase score by 10
           
        }
        scoreText.text = "Score: " + score.ToString();
        print(score);

        Destroy(transform.gameObject); //destroy the bullet
        explosion.SetActive(true); //unhide 
        Instantiate(explosion, transform.position, transform.rotation);
    }
}