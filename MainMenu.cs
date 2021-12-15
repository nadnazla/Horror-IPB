using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject fadeOut; 
    public AudioSource buttonClick;

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }


    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(1);
    }
}
