using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour { 

    private Rigidbody2D rb;
    public int currentHealth;
    public int maxHealth;
    public Health_Bar Health_Bar;
    int Health;
    public int heal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = GameObject.Find("Player").GetComponent<Character>().currentHealth;
        maxHealth = GameObject.Find("Player").GetComponent<Character>().maxHealth;
        if (currentHealth == 10)
        {
            Debug.Log("broke");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealDamage();
            Debug.Log("del");
            Destroy(gameObject);
        }
    }
    void HealDamage()
    {
        GameObject.Find("Player").GetComponent<Character>().currentHealth += heal;
        if (GameObject.Find("Player").GetComponent<Character>().currentHealth > maxHealth)
        {
            GameObject.Find("Player").GetComponent<Character>().currentHealth = maxHealth;
        }
        Health = GameObject.Find("Player").GetComponent<Character>().currentHealth;
        Health_Bar.SetHealth(Health);
    }
}
