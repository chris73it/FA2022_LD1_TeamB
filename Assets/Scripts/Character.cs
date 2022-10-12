using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public float speed = 5f;

    void Update()
    {
        if (health <= 0)
        {
            MrStarkIDontFeelSoGood();
        }
    }

    void MrStarkIDontFeelSoGood()
    {
        Destroy(this.gameObject);
    }
}
