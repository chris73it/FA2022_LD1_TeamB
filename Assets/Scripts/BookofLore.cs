using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookofLore : MonoBehaviour
{
    public InputManager input;
    [SerializeField]
    private Canvas pickUpText;

    public bool PickedUp;

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
}
