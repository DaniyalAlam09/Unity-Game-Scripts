using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject heli;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - heli.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = heli.transform.position + offset;
    }

}
