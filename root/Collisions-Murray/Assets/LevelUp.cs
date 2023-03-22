using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void OnClickStart()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            SceneManager.LoadScene("Collisions");
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
        
    }
    public void OnClickRestart()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
