using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] InputManager input;
    [SerializeField] Animator anim;

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Vertical", input.vertical);
        anim.SetFloat("Horizontal", input.horizontal);

        if (input.vertical == 0 && input.horizontal == 0)
        {
            anim.enabled = false;
        }
        else
        {
            anim.enabled = true;
        }

        if (input.vertical == 0)
        {
            anim.SetBool("Prioritize Vertical", false);
        }
        else
        {
            anim.SetBool("Prioritize Vertical", true);
        }
    }
}
