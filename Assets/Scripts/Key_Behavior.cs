using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Behavior : MonoBehaviour
{

    public InputManager input;
    [SerializeField]
    private Canvas pickUpText;

    public bool PickedUp;
    private bool pickUpAllowed;

    private void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);

            if (input.pickup)
            {
                Debug.Log("Picking up key");
                collision.GetComponent<Character>().getkey();
                Destroy(gameObject);

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
