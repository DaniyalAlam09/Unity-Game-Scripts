using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject me;
    void Start()
    {
        me= GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.5f);
        transform.LookAt(me.transform);
    }
}
