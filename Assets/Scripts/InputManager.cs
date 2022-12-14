using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public bool enabled = true;
    public bool isDead = false;

    public bool mouseLeft, mouseRight, reload, pause, pickup;
    public float horizontal, vertical;

    private void Start()
    {
        isDead = false;
        enabled = true;
    }
    void Update()
    {
        mouseLeft = Input.GetMouseButton(0);
        mouseRight = Input.GetMouseButton(1);
        if (enabled)
        {
            reload = Input.GetKey(KeyCode.R);

            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");

            pickup = Input.GetKey(KeyCode.F);
        }

        if (!isDead)
        {
            pause = Input.GetKey(KeyCode.Escape);
        }
    }
}
