using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //to change scene to first area on starting the game
    public void startGame()
    {
        //the center road area where you started
        SceneManager.LoadScene("FirstArea");
    }
    public void toCellar()
    {
        SceneManager.LoadScene("Cellar");
    }
    public void toCenterHouse()
    {
        SceneManager.LoadScene("CenterHouse");
    }
    public void toLeftHouse()
    {
        SceneManager.LoadScene("LeftHouse");
    }
    public void toRightHouse()
    {
        SceneManager.LoadScene("RightHouse");
    }
    public void toRightShed()
    {
        SceneManager.LoadScene("RightShed");
    }
    public void toRightRoad()
    {
        SceneManager.LoadScene("RightRoad");
    }
    public void toLeftRoad()
    {
        SceneManager.LoadScene("LeftRoad");
    }
    public void exitToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
