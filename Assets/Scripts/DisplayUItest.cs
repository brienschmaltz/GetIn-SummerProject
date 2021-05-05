using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayUItest : MonoBehaviour
{
    public Text myText;
    public bool displayInfo;


    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(displayInfo == false) 
        {
            myText.text = "";
        } else 
        {
            //Display text when looking. 
            myText.text = "Press 'e' to go up";
        }
        
    }
    void OnMouseOver()
    {
        displayInfo = true;
    }
    void OnMouseExit()
    {
        displayInfo = false;
    }
}
