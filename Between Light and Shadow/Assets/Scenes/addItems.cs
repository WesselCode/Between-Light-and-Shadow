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
        Debug.Log("item added");
        GameObject.Find("Water").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    //for empty bottle
    public void getEmptyBottle()
    {
        Inventory.Instance.addItem("empty bottle");
        Debug.Log("item added");
        GameObject.Find("EmptyBottle").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    //for cans
    public void getCan()
    {
        Inventory.Instance.addItem("food can");
        Debug.Log("item added");
        GameObject.Find("Can").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    //in case of second can
    public void getCan2()
    {
        Inventory.Instance.addItem("food can");
        Debug.Log("item added");
        GameObject.Find("Can2").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    //for table cloth, disable
    public void getTableCloth()
    {
        Inventory.Instance.addItem("cloth");
        GameObject.Find("TableCloth").GetComponent<UnityEngine.UI.Button>().interactable = false;
        Debug.Log("item added");
    }
    //for coat rack, disable
    public void getCoat()
    {
        Inventory.Instance.addItem("cloth");
        GameObject.Find("CoatRack").GetComponent<UnityEngine.UI.Button>().interactable = false;
        Debug.Log("item added");
    }
    //for clothes line, disable
    public void getSheet()
    {
        Inventory.Instance.addItem("cloth");
        GameObject.Find("ClothingLine").GetComponent<UnityEngine.UI.Button>().interactable = false;
        Debug.Log("item added");
    }
    //for the map
    public void getMap()
    {
        Inventory.Instance.addItem("full water");
        Debug.Log("item added");
        GameObject.Find("Map").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    //for misc product
    public void getMisc()
    {
        Inventory.Instance.addItem("misc");
        Debug.Log("item added");
        GameObject.Find("Product").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
    //for bolt cutters
    public void getCutters()
    {
        Inventory.Instance.addItem("bolt cutters");
        Debug.Log("item added");
        GameObject.Find("BoltCutters").GetComponent<UnityEngine.UI.Button>().interactable = false;
    }
}
