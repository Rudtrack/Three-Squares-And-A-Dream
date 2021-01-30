using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject HelpCanvas;

    public void PlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void HelpButton()
    {
        MainCanvas.SetActive(false);
        HelpCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackToMainMenuButton()
    {
        HelpCanvas.SetActive(false);
        MainCanvas.SetActive(true);
    }
}
