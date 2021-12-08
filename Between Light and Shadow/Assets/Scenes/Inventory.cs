using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    //to be able to acces this data anywhere, made a global instance to refer to
    public static Inventory Instance;

    //a list of Items is what an inventory is, will add and take away from this as needed
    //add crowbar and pocket knife ot start
    public List<Item> allItems = new List<Item>() { new Item("crowbar"), new Item("pocket knife") };

    //to be able to have other scenes access it, and it not be deleted throughout scene changes
    //have singleton status
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
    
    //at start, load data from the GlobalControl instance
    public void Start()
    {
        allItems = GlobalControl.Instance.items;
    }
    
    //save inventory to GlobalControl instance, call on scene change
    public void saveInventory()
    {
        GlobalControl.Instance.items = allItems;
    }

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
    //delete item from inventory if amount goes to zero
    public void loseItem(string theItem)
    {
        //fist get index and then check amounts, loseOne is called, then check if amount is 0
        int index = findItem(theItem);
        allItems[index].loseOne();
        if (allItems[index].getAmount() <= 0)
        {
            allItems.RemoveAt(index);
        }
    }

    //get the number of unique items in the inventory
    public int getCount()
    {
        if (allItems != null)
        {
            return allItems.Count;
        }
        return 0;
    }
    //for debug purposes to check if it is saving
    public void printInventory()
    {
        for (int i = 0; i < allItems.Count; i++)
        {
            Debug.Log(allItems[i].getName() + " | count: " + allItems[i].getAmount());
        }
    }

    //print inventory item at specific index:
    public string printItem(int index)
    {
        return allItems[index].getName() + " | count: " + allItems[index].getAmount();
    }

    //to manage which item is being used, items are single use
    public Item use;

    public void setUse(string name)
    {
        //set which item is currently in use
        use = allItems[findItem(name)];
        //NOTE: this is called in dropdown of all inventory items, no need to 
        //check if it is in the list
    }
}
