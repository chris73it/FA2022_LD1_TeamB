using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public Canvas Death;
    private Character Health;
    private int health;
    private void Start()
    {
        Health = GetComponent<Character>();
    }
    private void Update()
    {
        health = Health.currentHealth;
        death();
    }
    private void death()
    {
        if (health == 0)
        {
            Death.gameObject.SetActive(true);
        }
    }
}
