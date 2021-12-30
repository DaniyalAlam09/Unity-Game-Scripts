using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enim_controller : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject enemis;
    void Start()
    {
         for(int i=0; i<2; i++){
            Vector3 pos = new Vector3(Random.Range(650,660), -30 ,  Random.Range(430,530));
            Instantiate(enemis , pos, Quaternion.identity); 
    }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
