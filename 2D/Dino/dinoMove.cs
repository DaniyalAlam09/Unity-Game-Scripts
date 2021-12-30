using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoMove : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    private Rigidbody2D r;
    private bool m_FacingRight = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool  ("isWalk" , false);
        anim.SetBool  ("isDead" , false);
        anim.SetBool  ("isJump" , false);
        anim.SetBool  ("isRun" , false);
        anim.SetBool  ("idle" , true);
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isWalk", true);
            transform.Translate(0.02f, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalk", true);
            transform.Translate(-0.05f, 0, 0);
            Flip();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.up * Time.deltaTime*50 , Space.World);
            r.AddForce(Vector2.up * 1);
            anim.SetBool("isJump", true);
        }

        if (Input.GetKey(KeyCode.R))
        {
           
            anim.SetBool("isRun", true);
        }

        Vector2 pos = transform.position;

        if (pos.x >= 36)
        {
            pos.x = 0;
            transform.position = pos;
        }
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
