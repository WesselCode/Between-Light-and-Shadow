using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
    //to be able to acces this data anywhere, made a global instance to refer to
    public static Inventory Instance;

    //a list of Items is what an inventory is, will add and take away from this as needed
    //add crowbar and pocket knife ot start
    public List<Item> allItems = new List<Item>() { new Item("crowbar"), new Item("pocket knife") };

    //to be able to have other scenes access it, and it not be deleted throughout scene changes
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        /*if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }*/
        Instance = this;
        //inventory = gameObject.AddComponent<Inventory>();
        //add crowbar and pocket knife ot start
        //Inventory.Instance.Add(new Item("crowbar"));
        //Inventory.Instance.Add(new Item("pocket knife"));
    }
    //to allow each scene to have an inventory, and it will be the same inventory
    // void Start()
    /*{
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
        //inventory = gameObject.AddComponent<Inventory>();
        //add crowbar and pocket knife ot start
        Instance.addItem("crowbar");
        Instance.addItem("pocket knife");
    }*/
    //functions to work with the inventory
    //first check if an item is in the inventory by name, get the index if it is, return -1 otherwise
    public int findItem(string name)
    {
        int index = -1;
        for(int i = 0; i < allItems.Count; i++)
        {
            if (allItems[i].getName() == name)
            {
                index = i;
            }
        }

        return index;
    }
    //add new item to inventory/add another of previously existing item
    public void addItem(string theItem)
    {
        //only add the item as new if not already in inventory
        //if in inventory, just add to amount in Item class
        int index = findItem(theItem);
        //not in inventory
        if(index == -1)
        {
            allItems.Add(new Item(theItem));
        }
        else //its in the inventory
        {
            allItems[index].addOne();
        }
    }
    //get the number of unique items in the inventory
    public int getCount()
    {
        return allItems.Count;
    }
    //for debug purposes to check if it is saving
    public void printInventory()
    {
        for (int i = 0; i < allItems.Count; i++)
        {
            Debug.Log(allItems[i].getName());
        }
    }
}
