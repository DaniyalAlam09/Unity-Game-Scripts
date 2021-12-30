using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bullet.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("Hellicopter");
        }
    }
}
