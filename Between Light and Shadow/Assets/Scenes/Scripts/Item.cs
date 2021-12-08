using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    //to create an Item
    public Item(string _name)
    {
        name = _name;
        amount = 1;
    }

    //getter and setter functions for private variables
    public string getName()
    {
        return name;
    }

    public int getAmount()
    {
        return amount;
    }

    public void addOne()
    {
        amount++;
    }

    public void loseOne()
    {
        if(amount > 0)
        {
            amount--;
        }
    }

    //all items have a name
    private string name;
    //can have multiple of an item, when created, has 1 amount immediately
    private int amount = 1;
}
