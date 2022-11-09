using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door_Behavior : MonoBehaviour
{

    public InputManager input;

    [SerializeField]
    private Canvas OpenDoor;
    public int NextLevel;
    private bool EnterAllowed;

    public Text doorText;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            OpenDoor.gameObject.SetActive(true);
            Character player = collision.GetComponent<Character>();
            
            if (player.hasKey)
            {
                doorText.text = "Press 'F' to open door";
                if (input.pickup)
                {
                    SceneManager.LoadScene(NextLevel);
                }
            }
            else
            {
                doorText.text = "No. Go find the key";
            }

            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        //EnterAllowed = false;
        if (collision.gameObject.tag.Equals("Player"))
        {
            OpenDoor.gameObject.SetActive(false);
                
        }
    }
}