using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour { 

    private Rigidbody2D rb;
    [SerializeField]
    private Character health;
    private int currenthealth;
    public Health_Bar Health_Bar;
    int Health;
    public int heal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Character>();
        currenthealth = Health.currentHealth;
        if (Health == 10)
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
        Health = health + heal;
        Health_Bar.SetHealth(Health);
    }
}
