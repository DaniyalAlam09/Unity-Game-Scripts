using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;



public class PlayerController : MonoBehaviour
{
    private Animator playerAnimatorController;

    [SerializeField] private Joystick joystick;
    [SerializeField] private int movementForce = 2;
    [SerializeField] private int jumpForce = 2;
    private BannerView bannerView;
    private Rigidbody2D rb;
    public Text scoreText ;
    public Text highScoreText;
    public Text HealthText;
    public bool isGrounded;
    private int score = 0;
    private float health = 50;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
       // MobileAds.Initialize(initStatus => { });

         highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("score");
        this.RequestBanner();
        playerAnimatorController = GetComponent<Animator>();
        playerAnimatorController.SetInteger("state", 0);

         HealthText.text = "Health:" + health.ToString();
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal < 0 || Input.GetAxis("Horizontal") < 0) {
            rb.velocity = new Vector2(-movementForce, 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0); 
        }

        else if (joystick.Horizontal > 0 || Input.GetAxis("Horizontal") > 0) {
            rb.velocity = new Vector2(movementForce, 0);
             transform.localRotation = Quaternion.Euler(0, 0, 0); 
        }

        else {
           playerAnimatorController.SetInteger("state",0);
        }

        if (joystick.Vertical >= 0.5f || Input.GetAxis("Jump") > 0) {
            rb.velocity = new Vector2(0, jumpForce);
            playerAnimatorController.SetInteger("state",1);
        }

        // 0: idle
        // 1: jump
        // 2: fall
        // 3: run
        if (playerAnimatorController.GetInteger("state") == 1) {
            if (Mathf.Abs(rb.velocity.y) < 0.1f) {
                playerAnimatorController.SetInteger("state", 2);
            }
        } else if (playerAnimatorController.GetInteger("state") == 1) {
            if(isGrounded == true){
                playerAnimatorController.SetInteger("state",0);
            }
            
        } else if (Mathf.Abs(rb.velocity.x) > 2f) {
            playerAnimatorController.SetInteger("state", 3);
        } else {
            playerAnimatorController.SetInteger("state", 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.StartsWith("VEnemy"))
        {
            score += 10;
            Destroy(collision.collider.gameObject);
            scoreText.text = "Score:" + score.ToString();
            if(PlayerPrefs.GetInt("score")< score){
                 PlayerPrefs.SetInt("score", score);
             }
        }
         if (collision.collider.gameObject.name.StartsWith("Fruit"))
        {
            score += 5;
            Destroy(collision.collider.gameObject);
            scoreText.text = "Score:" + score.ToString();
            if(PlayerPrefs.GetInt("score")< score){
                 PlayerPrefs.SetInt("score", score);
             }
        }

        if (collision.collider.gameObject.name.StartsWith("Fire"))
        {
            health -= 10;
             HealthText.text = "Health:" + health.ToString();
        }
        if (collision.collider.gameObject.name.StartsWith("Spike"))
        {
            health -= 5;
             HealthText.text = "Health:" + health.ToString();
        }
        if (collision.collider.gameObject.name.StartsWith("Fruit"))
        {
            health += 10;
             HealthText.text = "Health:" + health.ToString();
             Destroy(collision.collider.gameObject);
             if(PlayerPrefs.GetInt("score")< score){
                 PlayerPrefs.SetInt("score", score);
             }
        }
        if (collision.collider.gameObject.name.StartsWith("Door"))
        {

            SceneManager.LoadScene("Level2Starter");
        }
      if(health<= 0){
           SceneManager.LoadScene("GameOver");
      }
    }
    private void OnCollisionStay2D(Collision2D collision){
        isGrounded = true;
    }
    private void RequestBanner()
    {
        
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
       

        // Create a 320x50 banner at the top of the screen.
        
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }
    // void OnTriggerEnter2D(Collision2D collision)
    // {
       
        
    // }
}
