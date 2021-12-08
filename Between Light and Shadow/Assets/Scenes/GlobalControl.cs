using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    //to be able to exit from the build executable
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    //to save data throughout scenes, create an inventory object here
    public static GlobalControl Instance;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    //an inventory to save to and use
    public List<Item> items = new List<Item>() { new Item("crowbar"), new Item("pocket knife") };

    //the boolean values to make sure buttons stay off/on if used or not:
    //fill buttonState: all buttons are already known, auto them all "on" which is 1:
    public Dictionary<string, int> buttonState = new Dictionary<string, int>() {
        { "Water", 1 }, {"EmptyBottle", 1 }, {"Can", 1 },
        { "Can2", 1}, {"TableCloth", 1}, {"CoatRack", 1},
        { "ClothingLine", 1}, {"Map", 1 }, {"Product", 1},
        { "BoltCutters", 1}, {"ShedKey", 1},
    };

    public bool checkActive(string keyName)
    {
        if (buttonState[keyName] == 1)
        {
            return true;//button stays active
        }
        else
        {
            //button is not active
            return false;
        }
    }

    public void deactive(string keyName)
    {
        buttonState[keyName] = 0;
        //button is no longer active, will fail checks
    }
}
