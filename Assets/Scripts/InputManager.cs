using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public bool check = true;

    public bool mouseLeft, mouseRight, reload, pause, pickup;
    public float horizontal, vertical;

    void Update()
    {
        if (check)
        {
            mouseLeft = Input.GetMouseButton(0);
            mouseRight = Input.GetMouseButton(1);
            reload = Input.GetKey(KeyCode.R);

            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");

            pickup = Input.GetKey(KeyCode.F);
        }

        pause = Input.GetKey(KeyCode.Escape);
    }
}
