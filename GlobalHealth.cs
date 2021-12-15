using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{

    public static int currentHealth = 20;
    public static bool DoorOpened = false;
    public bool DoorKey;
    public int inernalHealth;

    // Update is called once per frame
    void Update()
    {
        inernalHealth = currentHealth;
        DoorKey = DoorOpened;
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }

        if(DoorOpened == true)
        {
            SceneManager.LoadScene(3);
        }

    }
}
