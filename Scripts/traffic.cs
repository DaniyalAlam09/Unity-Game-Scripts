using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traffic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.3f);

        Vector3 pos = transform.position;
        if (pos.z > 48)
        {
            pos.z = -64;
            transform.position = pos;
        }
    }
}
