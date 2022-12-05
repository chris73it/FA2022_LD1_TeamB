using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int Level;
    
    public GameObject canvas;

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
}
