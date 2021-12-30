using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BulletScript.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("MainScene"); //this will load the scene mentioned in argument, dont forget to add the header file 
        }
    }
}
