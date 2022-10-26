using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Behavior : MonoBehaviour
{

    public Key_Behavior PickedUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PickedUp == true && Input.GetKeyDown(KeyCode.F))
        {

        }
        else if (PickedUp == false)
        {

        }
    }
}
