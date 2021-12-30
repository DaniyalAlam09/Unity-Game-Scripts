using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deadscirps : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score;
    Animator anim;
    public Text Health;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool  ("isWalk" , false);
        anim.SetBool  ("isDead" , false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col){
        // if(col.gameObject.name.StartsWith("Apple")){
        //     score += 10;
        //     // ("Apple");
        //     // Health.text -= score.ToString();
        //     // 
        // }
        if(col.gameObject.name.StartsWith("Saw")){
            score -= 10;
            // Health.text -= score.ToString();
        }
        if(score<0){
            anim.SetBool  ("isDead" , true);
        }
        Health.text += score.ToString();
    }
    //   public void OnCollisionEnter2D(Collision2D col){
        
    //     // print(score);
    //     Destroy(transform.gameObject);
    // }
    // print(score);
        // Destroy(transform.gameObject);

}
