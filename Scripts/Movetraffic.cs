using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetraffic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 10);

        Vector3 pos = transform.position;
        if (pos.z > 13663)
        {
            pos.z = -6122;
            transform.position = pos;
        }
    }

}
