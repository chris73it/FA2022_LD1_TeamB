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

    public void Setup(int dmg, string excludeName, LayerMask layer)
    {
        damage = dmg;
        this.gameObject.layer = layer;
        exclude = excludeName;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;

<<<<<<< HEAD

=======
        /*
>>>>>>> parent of eba7cb4 (Melee & Projectile Fix + Update)
        if (lifeTime > maxLife)
        {
            this.gameObject.SetActive(false);
            if (lifeTime > maxLife + rate)
            {
                lifeTime = 0;
                this.gameObject.SetActive(true);
            }
        }*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != exclude)
        {
<<<<<<< HEAD
            if (other.GetComponent<Character>().type != Character.CharacterType.Object)
=======
            Debug.Log("Melee attack connected");
            Rigidbody rb2d = other.GetComponent<Rigidbody>();

            if (rb2d != null)
>>>>>>> parent of eba7cb4 (Melee & Projectile Fix + Update)
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
