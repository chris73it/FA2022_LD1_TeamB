using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoAndReload : MonoBehaviour
{
    public Gun activeItem;
    public Text ammoText;
    //public Image activeIcon;
    public bool reloading = false;

    public void Update()
    {
        if (reloading)
        {
            if (activeItem != null) ammoText.text = "Reloading...";
        }
        else
        {
            if (activeItem != null) ammoText.text = "Ammo:" + activeItem.clipCurrent;
        } 
    }

    public void Setup()
    {
        if (activeItem != null)
        {
            //activeIcon.sprite = inv.activeItem.itemSprite;
            ammoText.text = "" + activeItem.clipCurrent;
        }
    }
}
