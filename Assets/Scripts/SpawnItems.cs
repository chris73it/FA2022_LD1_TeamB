using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    public Character spawner;

    [SerializeField]
    private GameObject Item;
    private Character Health;
    private int health;
    private void Start()
    {
        Health = GetComponent<Character>();
    }
    private void Update()
    {
        health = Health.currentHealth;
        if (health == 0)
        {
            doIt();
        }
    }

    public void doIt()
    {
        Vector3 spawnPos = this.transform.position;
<<<<<<< Updated upstream
        GameObject newItem = Instantiate(Item, spawnPos, Quaternion.identity);
=======
        GameObject Key = Instantiate(Item, spawnPos, Quaternion.identity);
>>>>>>> Stashed changes
    }

}
