using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        transform.Translate(0.3f, 0, 0);
        if (transform.position.x >= 25)
        {
            pos.x = -3.9f;
            transform.position = pos;

        }
    }
}
