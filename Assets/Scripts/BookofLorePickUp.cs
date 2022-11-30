using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookofLorePickUp : MonoBehaviour
{
    private InputManager input;

    [SerializeField] GameObject pickUpText;
    public SceneManager Level;
    public int chapterNumber;
    public GameObject button;

    private void Start()
    {
        input = GameObject.Find("GameManager").GetComponent<InputManager>();
        button = GameObject.Find("ChapterCtrl " + chapterNumber);
    }

    void PickedUp(bool isPickedUp)
    {
        Debug.Log("button");
        button.SetActive(isPickedUp);
        gameObject.SetActive(!isPickedUp);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);

            if (input.pickup)
            {
                Debug.Log("Picking up book");
                PickedUp(true);
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
