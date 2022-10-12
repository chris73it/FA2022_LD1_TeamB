using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public bool mouseLeft, mouseRight, reload;
    public float horizontal, vertical;

    void Update()
    {
        mouseLeft = Input.GetMouseButton(0);
        mouseRight = Input.GetMouseButton(1);
        reload = Input.GetKey(KeyCode.R);

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
}
