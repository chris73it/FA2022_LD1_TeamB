using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    public Character spawner;

    [SerializeField]
    private GameObject Item;

    public void doIt()
    {
        Vector3 spawnPos = this.transform.position;
        GameObject newEnemy = Instantiate(Item, spawnPos, Quaternion.identity);
    }

}
