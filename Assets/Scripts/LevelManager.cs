using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public int Level;
    public GameObject canvas;
    public GameObject main;
    public InputManager input;
    public void Start()
    {
        main = GameObject.Find("MainMenuCtrl");
    }
    public void StartGame()
    {
        canvas.SetActive(false);
        SceneManager.LoadScene(Level);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(Level);
    }
    public void Quit()
    {
        //canvas.SetActive(false);
        // main.GetComponent<MainMenuCtrl>().Canvas.SetActive(true);

        //unpause
        Time.timeScale = 1f;
        //input.enabled = true;
        SceneManager.LoadScene(Level);
        
    }
}
