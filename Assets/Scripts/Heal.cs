using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour { 

    private Rigidbody2D rb;
    public int maxHealth;
    public Health_Bar Health_Bar;
    int Health;
    public int heal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        maxHealth = GameObject.Find("Player").GetComponent<Character>().maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            HealDamage();
            Debug.Log("Healed");
            Destroy(gameObject);
        }
    }
    void HealDamage()
    {
        if (GameObject.Find("Player").GetComponent<Character>().currentHealth < maxHealth)
        {
            int amount = heal;
            int difference = maxHealth - GameObject.Find("Player").GetComponent<Character>().currentHealth;
            if (heal > difference)
            {
                amount = difference;
            }
            GameObject.Find("Player").GetComponent<Character>().Heal(amount);
        }

    }
}
