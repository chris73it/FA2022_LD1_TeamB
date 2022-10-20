using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public bool enabled = true;

    public bool mouseLeft, mouseRight, reload, pause;
    public float horizontal, vertical;

    void Update()
    {
        if (enabled)
        {
            mouseLeft = Input.GetMouseButton(0);
            mouseRight = Input.GetMouseButton(1);
            reload = Input.GetKey(KeyCode.R);

            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }

        pause = Input.GetKey(KeyCode.Escape);
    }
}
