using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class addItems : MonoBehaviour
{
    //to add items to the inventory instance, for use by buttons, a function a button
    //these are all on press for buttons in the first level, some must deactivate the buttons
    //use GetComponent<Button>().interactable = false; to disable buttons

    //for full water bottles:
    public void getWaterBottle()
    {
        //only d othis if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("Water")) {
            Inventory.Instance.addItem("full water");
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GameObject.Find("Water").GetComponent<UnityEngine.UI.Button>().interactable = false;
            GlobalControl.Instance.deactive("Water");
        }
    }
    //for empty bottle
    public void getEmptyBottle()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("EmptyBottle"))
        {
            Inventory.Instance.addItem("empty bottle");
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GameObject.Find("EmptyBottle").GetComponent<UnityEngine.UI.Button>().interactable = false;
            GlobalControl.Instance.deactive("EmptyBottle");
        }
    }
    //for cans
    public void getCan()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("Can"))
        {
            Inventory.Instance.addItem("food can");
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GameObject.Find("Can").GetComponent<UnityEngine.UI.Button>().interactable = false;
            GlobalControl.Instance.deactive("Can");
        }
    }
    //in case of second can
    public void getCan2()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("Can2"))
        {
            Inventory.Instance.addItem("food can");
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GameObject.Find("Can2").GetComponent<UnityEngine.UI.Button>().interactable = false;
            GlobalControl.Instance.deactive("Can2");
        }
    }
    //for table cloth, disable
    public void getTableCloth()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("TableCloth"))
        {
            Inventory.Instance.addItem("cloth");
            GameObject.Find("TableCloth").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("TableCloth");
        }
    }
    //for coat rack, disable
    public void getCoat()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("CoatRack"))
        {
            Inventory.Instance.addItem("cloth");
            GameObject.Find("CoatRack").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("CoatRack");
        }
    }
    //for clothes line, disable
    public void getSheet()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("ClothingLine"))
        {
            Inventory.Instance.addItem("cloth");
            GameObject.Find("ClothingLine").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Debug.Log("item added");
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("ClothingLine");
        }
    }
    //for the map
    public void getMap()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("Map"))
        {
            Inventory.Instance.addItem("Map");
            //Debug.Log("item added");
            GameObject.Find("Map").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("Map");
        }
    }
    //for misc product
    public void getMisc()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("Product"))
        {
            Inventory.Instance.addItem("misc");
            //Debug.Log("item added");
            GameObject.Find("Product").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("Product");
        }
    }

    //for bolt cutters
    public void getCutters()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("BoltCutters"))
        {
            Inventory.Instance.addItem("bolt cutters");
            //Debug.Log("item added");
            GameObject.Find("BoltCutters").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("BoltCutters");
        }
    }

    //for key
    public void getKey()
    {
        //only do this if still active, one use button so deactivate before leaving:
        if (GlobalControl.Instance.checkActive("ShedKey"))
        {
            Inventory.Instance.addItem("shed key");
            //Debug.Log("item added");
            GameObject.Find("ShedKey").GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Inventory.Instance.printInventory();
            GlobalControl.Instance.deactive("ShedKey");
        }
    }

    //to fill empty bottle, replace it in inventory with full bottle
    public void fillBottle()
    {
        //make sure the empty bottle is equiped:
        if (Inventory.Instance.use.getName() == "empty bottle") {
            //use the empty bottle, lose it and get a full one
            Inventory.Instance.loseItem("empty bottle");
            Inventory.Instance.addItem("full water");
            GameObject.Find("Sink").GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }

}
