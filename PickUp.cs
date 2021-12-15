using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public float TheDistance; 
    public GameObject ActionDisplay; 
    public GameObject ActionText; 
    public GameObject TheKey;


    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if(TheDistance <= 4)
        {
            ActionDisplay.GetComponent<Text>().text = "Pick up The Key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 4)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                TheKey.SetActive(false);
                GlobalInventory.firstDoorKey = true;
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
