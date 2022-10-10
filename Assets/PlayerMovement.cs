using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    float walkSpeed = 5f;
    float inputHorizontal;
    float inputVertical;


    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
            inputHorizontal = Input.GetAxisRaw("Horizontal");
            inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            rb.velocity = new Vector2(inputHorizontal, inputVertical).normalized * walkSpeed;

        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }   
}
