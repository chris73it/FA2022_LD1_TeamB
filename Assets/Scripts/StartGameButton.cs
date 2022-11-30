using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public int gameStartScene;
    public GameObject canvas;

    public void StartGame()
    {
        canvas.SetActive(false);
        SceneManager.LoadScene(gameStartScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
