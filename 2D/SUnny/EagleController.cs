using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Eagle;
    public GameObject Player;
   
    void Start()
    {
        Player = GameObject.Find("Squirrel");
        transform.Rotate(0,180,0);
        for (int i = 0; i < 1; i++)
        {
            Vector3 pos = new Vector3(Random.Range(3, -3), 2);
            Instantiate(Eagle, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1f, 1f, 0);
        transform.LookAt(Player.transform);
    }
   
}
