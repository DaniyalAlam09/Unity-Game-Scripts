using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;

    public CharacterController2D controller;

    public float runSpeed = 40f;
    private float startTouchPosition, endTouchPosition;
    private Rigidbody2D rb;
    public float m_JumpForce;
    float speed = 0.05f;
    public GameObject cloud;

    private float health =50;
    private float score = 0;

    public Text HealthText;
    public Text ScoreText;




    float move = 0f;
    float righthorizontalMove = 40f;
    float lefthorizontalMove = -40f;
    //private bool jumpAllowed = false;

    bool jump = false;
    bool crouch = false;

    void Start()
    {
        HealthText.text = "Health:" + health.ToString();
        ScoreText.text = "Score:" + score.ToString();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            var touch = Input.GetTouch(i);
            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position.y;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position.y;
                if (endTouchPosition > startTouchPosition)
                {
                    transform.Translate(Vector2.up * 250 * Time.fixedDeltaTime);
                }

            }
        }
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                controller.Move(lefthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("isWalk", true);
            }
            if (touch.position.x > Screen.width / 2)
            {
                controller.Move(righthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("isWalk", true);
            }
        }
        
        else
        {
            anim.SetBool("isWalk", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.StartsWith("cloud"))
        {
            print("coll");

            transform.gameObject.transform.parent = cloud.transform;
        }

        if (collision.gameObject.name.StartsWith("Saw"))
        {
            health -= 10;
            HealthText.text = "Health:" + health.ToString();
            if(health <= 0)
            {
                anim.SetTrigger("TriggerDead");
            }
        }

        if (collision.gameObject.name.StartsWith("apple"))
        {
            score += 10;
            ScoreText.text = "Score:" + score.ToString();
            Destroy(collision.gameObject);
        }

        
    }
}
