using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levMan : MonoBehaviour
{
   
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
  
    public void QuitGame()
    {
        Application.Quit();
    }
}
