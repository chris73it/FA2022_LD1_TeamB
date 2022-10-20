using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public enum CharacterType { Player, Enemy, Object };

    public int maxHealth = 10;
    public float speed = 5f;
    public int currentHealth;
    public Health_Bar healthBar;

    public CharacterType type;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        if (currentHealth <= 0)
        {
            MrStarkIDontFeelSoGood();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void MrStarkIDontFeelSoGood()
    {
        if (type == CharacterType.Player)
        {
            disablePlayer();
        }
        else if (type == CharacterType.Object)
        {
            //break animation
            SpawnMiniBoss spawner = this.GetComponent<SpawnMiniBoss>();
            if (spawner != null)
            {
                spawner.doIt();
            }
            Destroy(this.gameObject);
        }
        else
        {
            //death animation
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collided with: " + other.name);
        if (other.tag == "projectile")
        {
            if (other.GetComponent<Projectile>().exclude != this.gameObject.name)
            {
                TakeDamage(other.GetComponent<Projectile>().damage);
            }
        }
        if (other.tag == "melee")
        {
            if (other.GetComponent<Melee>().exclude != this.gameObject.name)
            {
                TakeDamage(other.GetComponent<Melee>().damage);
            }
        }
    }

    void disablePlayer()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<InputManager>().enabled = false;
    }
}
