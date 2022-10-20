using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObject : MonoBehaviour
{
    [SerializeField]
    private GameObject skeleton;
    [SerializeField]
    private GameObject ArmorSkeleton;

    [SerializeField]
    private float skeletonInterval = 3.5f;
    [SerializeField]
    private float ArmorSkeletonInterval = 10f;

    public bool randomInterval = true;


    void Start()
    {
        StartCoroutine(spawnEnemy(skeletonInterval, skeleton));
        StartCoroutine(spawnEnemy(ArmorSkeletonInterval, ArmorSkeleton));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(randomInterval ? interval + Random.Range(-2f, 5f) : interval);;

        Vector3 spawnPos = this.transform.position;
        Vector3 randomRange = new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0);
        spawnPos += randomRange;

        GameObject newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
