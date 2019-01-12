using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void GoGameScene()
    {
        SceneManager.LoadScene("GameMenuScene");
    }

    public void GoOptionScene()
    {
        SceneManager.LoadScene("OptionMenuScene");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
