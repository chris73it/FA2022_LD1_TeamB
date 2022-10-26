using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{

    public int damage;
    public float rate;

    float lifeTime = 0;
    float maxLife = 0.5f;
    float knockback = 15f;

    public string exclude;

    public Collider2D col;
    public Renderer sprite;

    public void Setup(int dmg, string excludeName, LayerMask layer)
    {
        damage = dmg;
        this.gameObject.layer = layer;
        exclude = excludeName;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeTime < maxLife + 1)
        {
            lifeTime += Time.deltaTime;
        }
<<<<<<< Updated upstream


=======

        
>>>>>>> Stashed changes
        if (lifeTime > maxLife)
        {
            disable();
        }
    }

    public void enable()
    {
        lifeTime = 0;
        col.enabled = true;
        sprite.enabled = true;
    }
    public void disable()
    {
        col.enabled = false;
        sprite.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != exclude)
        {
<<<<<<< Updated upstream
            if (other.GetComponent<Character>().type != Character.CharacterType.Object)
=======
            //Debug.Log("Melee attack connected");
            Rigidbody rb2d = other.GetComponent<Rigidbody>();

            if (rb2d != null)
>>>>>>> Stashed changes
            {
                Rigidbody2D rb2d = other.GetComponent<Rigidbody2D>();

                if (rb2d != null)
                {
                    Debug.Log("Attempting to knockback" + rb2d);
                    Vector2 dir = (transform.position - other.transform.position).normalized;
                    //rb2d.velocity += dir * knockback;
                    rb2d.AddForce(dir * knockback, ForceMode2D.Impulse);
                }
            }
        }
    }
}
