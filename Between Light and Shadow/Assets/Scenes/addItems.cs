using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addItems : MonoBehaviour
{
    //to add items to the inventory instance, for use by buttons, a function a button
    //these are all on press for buttons in the first level, some must deactivate the buttons
    //use GetComponent<Button>().interactable = false; to disable buttons

    //for full water bottles:
    public void getWaterBottle()
    {
        Inventory.Instance.addItem("full water");
    }
    //for empty bottle
    public void getEmptyBottle()
    {
        Inventory.Instance.addItem("empty bottle");
    }
    //for cans
    public void getCan()
    {
        Inventory.Instance.addItem("food can");
    }
    //for table cloth, disable
    public void getTableCloth()
    {
        Inventory.Instance.addItem("cloth");
        GetComponent<Button>().interactable = false;
    }
    //for coat rack, disable
    public void getCoat()
    {
        Inventory.Instance.addItem("cloth");
        GetComponent<Button>().interactable = false;
    }
    //for clothes line, disable
    public void getSheet()
    {
        Inventory.Instance.addItem("cloth");
        GetComponent<Button>().interactable = false;
    }
}
