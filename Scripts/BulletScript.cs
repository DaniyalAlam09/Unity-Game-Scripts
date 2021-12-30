using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
     public Text scoreText;

    public static float score = 0;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(-10000, 0, 0);
        scoreText.text ="Score: " +0;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, 0, 3);
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name.StartsWith("Enemy"))
        {
            score+=5;
        }
        scoreText.text="Score: " +score.ToString(); 
        print(score);
        // Destroy(transform.gameObject);
    }
}
