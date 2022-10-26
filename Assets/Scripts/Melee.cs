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

        /*
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
            Debug.Log("Melee attack connected");
            Rigidbody rb2d = other.GetComponent<Rigidbody>();

            if (rb2d != null)
            {
                Vector2 dir = (other.transform.position - transform.position);
                rb2d.velocity = dir * knockback;
            }
        }
    }
}
