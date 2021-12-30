using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour
{
    // Start is called before the first frame update
    private bool m_FacingRight = true;
    private float mon;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 pos = new Vector3(-3.1f,-3,67f);
        StartCoroutine(move());
        // for(int i=0; i<10; i++)
        // {
        //     if (mon = pos.x)
        //     {
        //         Flip();
        //     }


        // }
        
    }
    IEnumerator move()
    {
        yield return new WaitForSeconds(15.0f);
        transform.Translate(-0.01f, 0,0);
        // move();
        // Flip();
        // transform.Translate(0.01f, 0,0);
    }
    private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}