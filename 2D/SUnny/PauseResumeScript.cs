using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseResumeScript : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

  public void ResumeGame()
    {
        Time.timeScale = 1;
    }


    public void EndGame()
    {
        Application.Quit();
    }
    public void Menu(){
        SceneManager.LoadScene("Starter");
    }
}
