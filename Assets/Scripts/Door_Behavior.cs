using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door_Behavior : MonoBehaviour
{
    [SerializeField]
    private Canvas OpenDoor;
    public Key_Behavior PickedUp;
    public int NextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PickedUp == true)
        {
            Debug.Log("true");
            if (collision.gameObject.tag.Equals("Player"))
            {
                OpenDoor.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    NextLevel = '3';
                }
            }

        }
        else if (PickedUp == false)
        {
            if (collision.gameObject.tag.Equals("Player"))
            {
                OpenDoor.gameObject.SetActive(false);
                
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (PickedUp == true)
        {
            if (collision.gameObject.tag.Equals("Player"))
            {
                OpenDoor.gameObject.SetActive(false);
                
            }
        }
    }
    
}
