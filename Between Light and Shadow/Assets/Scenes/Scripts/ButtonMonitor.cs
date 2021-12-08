using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonMonitor : MonoBehaviour
{
    //in awake check button status:
    //DOES NOTHING AS OF NOW
    /*void Awake()//part of attempt to get buttons to stay off when entering scene
     {
         try
         {
             GameObject.Find("Water").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("Water");
             GameObject.Find("EmptyBottle").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("EmptyBottle");
             GameObject.Find("Can").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("Can");
             GameObject.Find("Can2").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("Can2");
             GameObject.Find("TableCloth").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("TableCloth");
             GameObject.Find("CoatRack").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("CoatRack");
             GameObject.Find("ClothingLine").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("ClothingLine");
             GameObject.Find("Map").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("Map");
             GameObject.Find("Product").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("Product");
             GameObject.Find("BoltCutters").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("BoltCutters");
             GameObject.Find("ShedKey").GetComponent<UnityEngine.UI.Button>().interactable = GlobalControl.Instance.checkActive("ShedKey");
         }
         catch (Exception e)
         {
            Debug.Log("button not in scene");
            Debug.Log(e);
         }
     }*/
}
