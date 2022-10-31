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
    private bool EnterAllowed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PickedUp == true)
        {
            EnterAllowed = true;
            Debug.Log("true");
            if (collision.gameObject.tag.Equals("Player"))
            {
                OpenDoor.gameObject.SetActive(true);
                
            }

        }
        else if (PickedUp == false)
        {
            EnterAllowed = false;
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
            EnterAllowed = false;
            if (collision.gameObject.tag.Equals("Player"))
            {
                OpenDoor.gameObject.SetActive(false);
                
            }
        }
    }
    private void Update()
    {
        if (EnterAllowed == true && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("yea");
            SceneManager.LoadScene(NextLevel);
        }
    }
}
