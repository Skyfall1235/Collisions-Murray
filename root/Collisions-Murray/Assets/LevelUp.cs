using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public void OnClick()
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
}
