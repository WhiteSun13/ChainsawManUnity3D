using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMBtn : MonoBehaviour
{
    public GameObject loadPanel;
    public GameObject ExitPanel;
    public void PlayGame()
    {
        loadPanel.SetActive(true);
    }
    public void QuitGameQuest()
    {
        ExitPanel.SetActive(true);
    }
    public void QuitGameNo()
    {
        ExitPanel.SetActive(false);
    }
    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
