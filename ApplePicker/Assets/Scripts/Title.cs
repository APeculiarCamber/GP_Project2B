using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    GameObject title;
    [SerializeField]
    GameObject credits;
    [SerializeField]
    GameObject controls;

    private void Start()
    {
        credits.SetActive(false);
        controls.SetActive(false);
        title.SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void goBack()
    {
        credits.SetActive(false);
        controls.SetActive(false);
        title.SetActive(true);
    }

    public void goToCredits()
    {
        credits.SetActive(true);
        controls.SetActive(false);
        title.SetActive(false);
    }

    public void goToControls()
    {
        credits.SetActive(false);
        controls.SetActive(true);
        title.SetActive(false);
    }
}
