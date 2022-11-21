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
    public XP_Bar xpBar;
    public SpawnItems dropItem;
    public GameObject keyImage;

    public CharacterType type;

    private bool disabled = false;
    public bool hasKey = false;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        if (type != CharacterType.Player)
        {
            healthBar.SetHealth(0);
        }
        else
        {
            keyImage.SetActive(false);
        }
    }
    void Update()
    {
        if (currentHealth <= 0 && !disabled)
        {
            MrStarkIDontFeelSoGood();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            //thanos snap
            TakeDamage(20);
        }
    }
    public void getkey()
    {
        if (type == CharacterType.Player)
        {
            hasKey = true;
            keyImage.SetActive(true);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void Heal(int health)
    {
        currentHealth += health;
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
        else //if is enemy
        {
            //death animation
            if (dropItem != null)
            {
                dropItem.doIt();
                dropItem.dropchance();
            }
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
        this.GetComponent<SpriteRenderer>().enabled = false; // broken
        this.GetComponent<InputManager>().enabled = false;
        GameObject.Find("Arm").SetActive(false);
        disabled = true;
    }
}
