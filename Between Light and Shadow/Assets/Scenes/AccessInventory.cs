using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class AccessInventory : MonoBehaviour
{
    //on clicking the inventory button, create a dropdown menu, should be temp
    //allow user to access item they want to use from there, set item in use to Inventory instance
    //as its own variable
    void Start()
    {
        var dropdown = GameObject.Find("Selection").GetComponent<UnityEngine.UI.Dropdown>();
        //clear current options:
        dropdown.options.Clear();

        //make a string of options from the inventory:
        string[] items = new string[Inventory.Instance.getCount()];
        Debug.Log(Inventory.Instance.getCount());
        for (int i = 0; i < Inventory.Instance.getCount(); i++)
        {
            items[i] = Inventory.Instance.printItem(i);
        }
        //make a dropdown menu with those values:
        //first make it accessable:
        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        //Debug.Log(index);
        string selected = dropdown.options[index].text;
        //Debug.Log(selected);
        string itemChosen = selected.Remove(selected.Length-11);
        //Debug.Log(itemChosen);
        Inventory.Instance.setUse(itemChosen);
        //edit the textbox over the dropdown saying what is equiped:
        GameObject.Find("Equiped").GetComponent<UnityEngine.UI.Text>().text = "Equiped: " + itemChosen;
    }

    public void UpdateInventory()
    {
        var dropdown = GameObject.Find("Selection").GetComponent<UnityEngine.UI.Dropdown>();
        //clear current options:
        dropdown.options.Clear();

        //make a string of options from the inventory:
        string[] items = new string[Inventory.Instance.getCount()];
        Debug.Log(Inventory.Instance.getCount());
        for (int i = 0; i < Inventory.Instance.getCount(); i++)
        {
            items[i] = Inventory.Instance.printItem(i);
        }
        //make a dropdown menu with those values:
        //first make it accessable:
        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

}
