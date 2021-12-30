using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static float score;
    public Text Health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name.StartsWith("Dino")){
            score += 10;
            
            
        }
        Destroy(transform.gameObject);
        Health.text += score.ToString();
        print(score);
    }
}
