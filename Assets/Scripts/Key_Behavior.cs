using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Behavior : MonoBehaviour
{

    private InputManager input;
    [SerializeField]
    private GameObject pickUpText;

    public bool PickedUp;

    private void Start()
    {
        input = (InputManager)FindObjectOfType(typeof(InputManager));
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.SetActive(true);

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
            pickUpText.SetActive(false);
        }
    }
}
