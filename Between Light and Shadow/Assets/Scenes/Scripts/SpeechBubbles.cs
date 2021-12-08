using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbles : MonoBehaviour
{
    //on press will need to change make the button non-interactable
    //and change color of text to disappear
    public void getRidOfSpeech()
    {
        GameObject.Find("Speech").GetComponent<UnityEngine.UI.Button>().interactable = false;
        //lower text opacity to 0
        GameObject.Find("said").GetComponent<UnityEngine.UI.Text>().color = new Color(0, 0, 0, 0);
    }

    //this is the function that makes the button interactble and text black
    //this occurs in one of two places right now
    public void activateButton()
    {
        //first the Speech button
        GameObject.Find("Speech").GetComponent<UnityEngine.UI.Button>().interactable = true;
        //now change text to black, text is labeled "said":
        GameObject.Find("said").GetComponent<UnityEngine.UI.Text>().color = new Color(0, 0, 0, 255);
    }
}
