using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookofLore : MonoBehaviour
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
            pickUpText.gameObject.SetActive(true);

            if (input.pickup)
            {
                Debug.Log("Picking up book");
                gameObject.SetActive(false);

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
        }
    }
}
