using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    int damage;
    float speed = 20;
    bool speedFallOff = false;

    float lifeTime = 0;
    float maxLife = 1.5f;

    public void Setup(int dmg, float spd, bool fallOff, LayerMask layer)
    {
        damage = dmg;
        speed = spd;
        speedFallOff = fallOff;
        this.gameObject.layer = layer;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
        transform.position += transform.right * speed * Time.deltaTime;

        if (speedFallOff)
        {
            speed -= 1f * Time.deltaTime;
        }

        if (lifeTime > maxLife)
        {
            Destroy(this.gameObject);
        }
    }
}
