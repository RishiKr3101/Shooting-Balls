using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenchanger : MonoBehaviour
{

    public void Menu()
    {
        SceneManager.LoadScene("Home");

    }
    

    public void QuitGame()
    {
        Application.Quit();
    }
}
    