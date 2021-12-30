using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerMovement : MonoBehaviour
{
    // [SerializeField] GameObject Menu;
    public CharacterController2D controller;
    private float startTouchPosition, endTouchPosition;

    public float runSpeed = 10f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    private float health =50;
    private static int score = 0;
    public Text HealthText;
    public Text HighScore;
    public Text ScoreText;
    
    
    Animator anim;

    float move = 0f;
    float righthorizontalMove = 40f;
    float lefthorizontalMove = -40f;
    // bool jump = false;
    private Rigidbody2D r;
    public AudioSource eat;
    public AudioSource hurt;
    public AudioSource bonus1;
    public AudioSource bonus2;
    public AudioSource dead;

    // Update is called once per frame
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool  ("isRun" , false);
        anim.SetBool  ("isIdle" , false);
        anim.SetBool  ("isClimb" , false);
        anim.SetBool  ("isJump" , false);
        anim.SetBool  ("isHurt" , false);
        anim.SetBool  ("isSpark" , false);
        r = GetComponent<Rigidbody2D>();
        eat = GetComponent<AudioSource>();
        hurt = GetComponent<AudioSource>();
        bonus1 = GetComponent<AudioSource>();
        bonus2 = GetComponent<AudioSource>();
        dead = GetComponent<AudioSource>();
        HighScore.text = "Highscore : " + PlayerPrefs.GetInt("score");
    }
    void Update()
    {
        // bonus();

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            // anim.SetBool  ("isJump" , true);
            
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isRun", false);
            anim.SetBool("isJump", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", false);
        }

        // for (int i = 0; i < Input.touchCount; i++)
        // {
        //     var touch = Input.GetTouch(i);
        //     if (touch.phase == TouchPhase.Began)
        //     {
        //         startTouchPosition = touch.position.y;
        //     }
        //     else if (touch.phase == TouchPhase.Ended)
        //     {
        //         endTouchPosition = touch.position.y;
        //         if (endTouchPosition > startTouchPosition)
        //         {
        //             transform.Translate(Vector2.up * 100 * Time.fixedDeltaTime);
        //         }

        //     }
        // }

        //if (Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //}
        //else if (Input.GetButtonUp("Crouch"))
        //{
        //    crouch = false;
        //}

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2 &&  touch.position.y > Screen.height / 8)
            {
                controller.Move(lefthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("isRun", true);
            }
            if (touch.position.x > Screen.width / 2 &&  touch.position.y > Screen.height / 8)
            {
                controller.Move(righthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("isRun", true);
            }
        }
        
        else
        {
            anim.SetBool("isRun", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name.StartsWith("gem-1"))
        {
            score += 10;
            ScoreText.text = "Score:" + score.ToString();
            Destroy(collision.gameObject);
            bonus1.Play();
            if(PlayerPrefs.GetInt("score")< score){
                 PlayerPrefs.SetInt("score", score);
             }
        }
        if (collision.gameObject.name.StartsWith("Frog"))
        {
            anim.Play("isHurt");
            health -= 10;
            HealthText.text = "Health:" + health.ToString();
             StartCoroutine(wait());
            // Destroy(collision.gameObject);
            // anim.SetBool  ("frogDead" , true);
            score += 10;
            ScoreText.text = "Score:" + score.ToString();
            if(health <= 0)
            {
                SceneManager.LoadScene("Over");
                dead.Play();
            }
            if(PlayerPrefs.GetInt("score")< score){
                 PlayerPrefs.SetInt("score", score);
             }
            hurt.Play();
            
        }
        if (collision.gameObject.name.StartsWith("eagle"))
        {
            
            score += 10;
            health -= 10;
            ScoreText.text = "Score:" + score.ToString();
            HealthText.text = "Health:" + health.ToString();
            Destroy(collision.gameObject);
            hurt.Play();
            if(PlayerPrefs.GetInt("score")< score){
                 PlayerPrefs.SetInt("score", score);
             }
            
        }
        if (collision.gameObject.name.StartsWith("Friut"))
        {
            health += 10;
            HealthText.text = "Health:" + health.ToString();
            Destroy(collision.gameObject);
            eat.Play();
        }
        if (collision.gameObject.name.StartsWith("Next"))
        {
                SceneManager.LoadScene("Level2Start");
                bonus2.Play();
        }
        if (collision.gameObject.name.StartsWith("Mace"))
        {
                SceneManager.LoadScene("Over");
                dead.Play();
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.0f);
    }
    // public void Awake()
    // {
    //     Menu.SetActive(false);
    //      //hide menu in the start
    // }

    // public void ShowMenu()
    // {
    //     Menu.SetActive(true);
    // }

    // public void HideMenu()
    // {
    //     Menu.SetActive(false);
    // }
    // public void bonus(){
    //     if(score >= 20){
    //         Time.timeScale = 0;
    //         Menu.SetActive(true);
    //     }
    // }
    // public void ResumeGame()
    // {
    //     Time.timeScale = 1;
    // }
}