using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    //load the scene
     public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );

    }
    //quit the game
    public void Quit()
    {
        Application.Quit();
        
    }
}
