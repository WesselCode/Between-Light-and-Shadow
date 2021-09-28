using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //to change scene to first area on starting the game
    public void startGame()
    {
        SceneManager.LoadScene("FirstArea");
    }

    public void exitToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
