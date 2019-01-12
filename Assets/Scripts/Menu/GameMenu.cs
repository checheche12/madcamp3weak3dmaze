using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    
    public void GoAlonePlay()
    {
        SceneManager.LoadScene("AlonePlayScene");
    }

    public void GoMultiPlay()
    {
        SceneManager.LoadScene("MultiPlayScene");
    }

    public void GoMainScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
