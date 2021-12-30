using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelicopterScript : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.D))

        {
            transform.Translate(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.X))

        {
            Vector3 heliposition = transform.position;
            heliposition.y -= 1.5f;

            Instantiate(bullet, heliposition, transform.rotation);
        }


    }

   private void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
