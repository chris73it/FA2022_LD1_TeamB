using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    public Character spawner;

    [SerializeField]
    private GameObject Item;
    [SerializeField]
    private GameObject Drop;
    const float m_dropChance = 1f / 10f;

    public void doIt()
    {
        Vector3 spawnPos = this.transform.position;
        GameObject newItem = Instantiate(Item, spawnPos, Quaternion.identity);
    }

    public void dropchance()
    {
       // if (Random.Range(0f, 1f) <= m_dropChance)
      //  {
            Vector3 spawnPos = this.transform.position;
            GameObject newItem = Instantiate(Drop, spawnPos, Quaternion.identity);
       // }
    }
    
}
