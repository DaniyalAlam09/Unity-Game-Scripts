using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMenu() {
        panel.SetActive(true);
    }

    public void HideMenu()
    {
        panel.SetActive(false);
    }

}
