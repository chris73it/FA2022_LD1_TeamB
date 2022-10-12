using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectMouse : MonoBehaviour
{
    public bool mouseDown = false;
    private void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " was selected!");
        mouseDown = true;
    }

    private void OnMouseUp()
    {
        mouseDown = false;
    }
}
