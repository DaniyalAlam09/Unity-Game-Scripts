using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        transform.Translate(0, 0, 50);

        Vector3 pos = transform.position;
        if (pos.z > 770)
        {
            pos.z = -30;
            transform.position = pos;
        }
    }
}
