using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMiniBoss : MonoBehaviour
{

    public Character spawner;

    [SerializeField]
    private GameObject miniBoss;

    public void doIt()
    {
        Vector3 spawnPos = this.transform.position;
        GameObject newEnemy = Instantiate(miniBoss, spawnPos, Quaternion.identity);
    }
}
