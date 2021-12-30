using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gem;
    void Start()
    {
        for(int i=0; i<7; i++){
            Vector3 pos = new Vector3(Random.Range(-3,1), 1);
            Instantiate(gem , pos, Quaternion.identity);  
        }
        for(int i=0; i<4; i++){
            Vector3 pos = new Vector3(Random.Range(0,3), -1);
            Instantiate(gem , pos, Quaternion.identity);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

