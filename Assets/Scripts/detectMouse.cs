using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectMouse : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " was selected!");
    }
}
