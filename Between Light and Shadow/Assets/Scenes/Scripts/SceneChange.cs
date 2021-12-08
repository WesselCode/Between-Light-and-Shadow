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
        //add condition that bolt cutters are needed to get in here
        //if they are the equiped item, you can pass
        if (Inventory.Instance.use.getName() == "bolt cutters") {
            SceneManager.LoadScene("Cellar");
        }
    }
    public void toCenterHouse()
    {
        SceneManager.LoadScene("CenterHouse");
    }
    public void toLeftHouse()
    {
        //must get rid of the boards before entering the house
        if (GameObject.Find("boards").GetComponent<UnityEngine.UI.Button>().interactable == false) {
            SceneManager.LoadScene("LeftHouse");
        }
    }
    public void toRightHouse()
    {
        SceneManager.LoadScene("RightHouse");
    }
    public void toRightShed()
    {
        if (Inventory.Instance.use.getName() == "shed key") {
            SceneManager.LoadScene("RightShed");
        }
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
