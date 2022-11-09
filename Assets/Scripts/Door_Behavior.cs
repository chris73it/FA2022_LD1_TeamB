using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door_Behavior : MonoBehaviour
{
    [SerializeField]
    private Canvas OpenDoor;
    public int NextLevel;
    private bool EnterAllowed;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.Find("Key_Image").GetComponent<Key_Behavior>().PickedUp == true)
        {
            EnterAllowed = true;
            Debug.Log("true");
            if (collision.gameObject.tag.Equals("Player"))
            {
                OpenDoor.gameObject.SetActive(true);
                
            }

        }
        else if (GameObject.Find("Key_Image").GetComponent<Key_Behavior>().PickedUp == false)
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
        if (GameObject.Find("Key_Image").GetComponent<Key_Behavior>() == true)
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

        if (GameObject.Find("Key_Image").GetComponent<Image>() == true)
        {
            Debug.Log("true");
        }
        if (EnterAllowed == true && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("yea");
            SceneManager.LoadScene(NextLevel);
        }
    }
}