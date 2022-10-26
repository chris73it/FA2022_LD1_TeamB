using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{

    public int damage;
    public float rate;

    float lifeTime = 0;
    float maxLife = 0.5f;
    float knockback = 30f;

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
            //Debug.Log("Melee attack connected");
            Rigidbody rb2d = other.GetComponent<Rigidbody>();

            if (rb2d != null)
            {
                Vector2 dir = (other.transform.position - transform.position);
                rb2d.velocity = dir * knockback;
            }
        }
    }
}
