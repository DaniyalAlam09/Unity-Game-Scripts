using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Apple;
    void Start()
    {
        for(int i=0; i<3; i++){
            Vector3 pos = new Vector3(Random.Range(-170,-110), 15);
            Instantiate(Apple , pos, Quaternion.identity);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
