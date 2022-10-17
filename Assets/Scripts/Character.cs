using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public float speed = 5f;
    public int currentHealth;
    public Health_Bar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        if (health <= 0)
        {
            MrStarkIDontFeelSoGood();
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    void MrStarkIDontFeelSoGood()
    {
        Destroy(this.gameObject);
    }
}
