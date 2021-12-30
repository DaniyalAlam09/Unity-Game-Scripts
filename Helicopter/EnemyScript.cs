using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject me;
    // Start is called before the first frame update
    void Start()
    {
       // me = GameObject.Find("Helicopter"); //when your gameobject is private
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.1f);
        transform.LookAt(me.transform);
    }
}
