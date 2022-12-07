using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookofLore : MonoBehaviour
{
    private InputManager input;

    public SceneManager Level;

    public int chapterNumber;
    public GameObject button;

    private void Start()
    {
        //button = GameObject.Find("ChapterLore " + chapterNumber);
    }
}
