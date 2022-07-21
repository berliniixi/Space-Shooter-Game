using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //load to the Intro scene
    public static void playGame()
    {
        SceneManager.LoadScene("Intro");
    }
    //load to the Game scene
    public void intro()
    {
        SceneManager.LoadScene("Game"); 
    }
    //load back to the Main scene
    public void goBack()
    {
        SceneManager.LoadScene("Main");
    }
    //Exit from the game
    public void quitGame()
    {
        Application.Quit();
    }
}
