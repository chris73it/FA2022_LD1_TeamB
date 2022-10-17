using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    public GameObject Canvas;
    bool Paused = false;

    void Start()
    {
        Canvas.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Paused == true)
            {
                Canvas.gameObject.SetActive(true);
                Time.timeScale = 0f;
                Paused = false;
            } else
            {
                Time.timeScale = 0f;
                Canvas.gameObject.SetActive(true);
                Paused = true;
            }
        }
    }

    
   public void Resume()
    {
        
    }
}
