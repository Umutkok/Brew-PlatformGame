using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void restartbutton()
    {
        SceneManager.LoadScene("MainMenu_Umut");
    }

    public void exitbutton()
    {
        Application.Quit();
    }

}
