using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour { 

    private Rigidbody2D rb;
    [SerializeField]
    Character health;
    public Health_Bar Health_Bar;
    static int Health;
    public int heal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = Character.
        if (Health = 10)
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
        Health = Health + heal;
        Health_Bar.SetHealth(Health);
    }
}
