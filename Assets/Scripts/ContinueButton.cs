using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public GameObject Pause;
    void start()
    {
        if (Pause == false) {
            GameObject.Find("GameManager").GetComponent<InputManager>().enabled = true;
        }
       
    }
}
