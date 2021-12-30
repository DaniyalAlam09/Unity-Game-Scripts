using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour

{
    public float speed;
	public GameObject object1; // The game object that moves.
	public GameObject object2;
	 private bool m_FacingRight = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Flip();
        
    }
    void FixedUpdate()
	{
		// Calculate direction vector.
		Vector3 dirction = object1.transform.position - object2.transform.position;

		// Normalize resultant vector to unit Vector.
		dirction = -dirction.normalized;

		// Move in the direction of the direction vector every frame.
		object1.transform.position += dirction * Time.deltaTime * speed;
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
