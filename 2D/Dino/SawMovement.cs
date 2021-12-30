using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SawMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score;
    Animator anim;
    public Text Health;
     public Vector2 pos1;
    public Vector2 pos2;
    public Vector2 posDiff = new Vector2(6f, 0f);
    float speed= 1;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool  ("isWalk" , false);
        anim.SetBool  ("isDead" , false);
        pos1 = transform.position;
        pos2 = pos1 + posDiff;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        transform.Rotate(0,0,3f);
    }
    // public void OnCollisionEnter2D(Collision2D col){
    //     if(col.gameObject.name.StartsWith("Dino")){
    //         score -= 10;
    //         // Health.text -= score.ToString();
    //         Health.text += score.ToString();
    //     }
        // print(score);
        // // Destroy(transform.gameObject);
        // if(score<0){
        //     anim.SetBool  ("isDead" , true);
        // }
    }
