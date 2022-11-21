using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookofLore : MonoBehaviour
{
    private InputManager input;
    [SerializeField]
    private GameObject pickUpText;
    public SceneManager Level;
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
                PickedUp = true;

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
    private void Update()
    {
            if (PickedUp == true)
        {

        }
    }
}
