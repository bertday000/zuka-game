using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject gameOverUi;
    [SerializeField] GameObject gameUi;

    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadGameOverUi() 
    {
        gameOverUi.SetActive(true);
        gameUi.SetActive(false);
    }
}
