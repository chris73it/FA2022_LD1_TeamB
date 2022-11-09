using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Behavior : MonoBehaviour
{
    [SerializeField]
    private Canvas pickUpText;
    public Image image;

    public bool PickedUp;
    private bool pickUpAllowed;

    private void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Character player = collision.GetComponent<Character>();

        if (player != null)
        {
            //Debug.Log("Found player");
            pickUpText.gameObject.SetActive(true);

            InputManager input = collision.GetComponent<InputManager>();

            if (input != null)
            {
                //Debug.Log("Input Manager found");
                //if (input.pickup)
                //{
                    Debug.Log("Picking up key");
                    player.getkey();
                    Destroy(gameObject);

               // }

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            //pickUpAllowed = false;
        }
    }
}
