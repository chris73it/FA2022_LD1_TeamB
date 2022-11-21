using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverHighlight : MonoBehaviour
{

    //this whole script does stuff it doesn't need to, but it works :shrug:

    public Color startColor, mouseOverColor;
    public Renderer planeRenderer;

    private void Start()
    {
        planeRenderer.material.SetColor("_Color", startColor);
    }

    private void OnMouseEnter()
    {
        planeRenderer.material.SetColor("_Color", mouseOverColor);
    }

    private void OnMouseExit()
    {
        planeRenderer.material.SetColor("_Color", startColor);
    }
}
