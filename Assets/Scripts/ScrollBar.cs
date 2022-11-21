using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScrollBar : MonoBehaviour
{
    public TextMeshProUGUI Lore;

    private ScrollBar scroll;

    void Start()
    {
        scroll = GetComponent<ScrollBar>();
    }

    public void Update()
    {
        
    }
}
