using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    public detectMouse mouse;
    public int level;

    // Update is called once per frame
    void Update()
    {
        if (mouse.mouseDown)
        {
            SceneManager.LoadScene(level);
        }
    }
}
