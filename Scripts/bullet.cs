using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public GameObject explosion;
    public Text scoreText;

    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text ="Score: " +0;
    }

    // Update is called once per frame
   void Update()
    {
        transform.Translate(0, 0, 4);
        explosion.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.StartsWith("Terrain"))
        {
            Destroy(collision.gameObject); //it will destroy that game object which collides with helicopter
            score+=10;
        }
        scoreText.text="Score: " +score.ToString(); 
        print(score);

        Destroy(transform.gameObject);
        explosion.SetActive(true);
        Instantiate(explosion, transform.position, transform.rotation);


    }
}