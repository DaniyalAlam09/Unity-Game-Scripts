using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgManager : MonoBehaviour
{
    public GameObject forest, sand, on, off;

    // Start is called before the first frame update
    void Start()
    {
        forest.SetActive(true);
        sand.SetActive(false);
        off.SetActive(true);
        on.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowSand()
    {
        sand.SetActive(true);
        forest.SetActive(false);
        off.SetActive(false);
        on.SetActive(true);
    }

    public void ShowForest()
    {
        sand.SetActive(false);
        forest.SetActive(true);
        off.SetActive(true);
        on.SetActive(false);
    }
}
