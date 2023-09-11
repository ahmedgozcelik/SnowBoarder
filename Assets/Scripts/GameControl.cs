using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject gameoverPanel;
    public void OpenGameOverPanel()
    {
        gameoverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
}