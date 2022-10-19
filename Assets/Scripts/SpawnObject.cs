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


    void Start()
    {
        StartCoroutine(spawnEnemy(skeletonInterval, skeleton));
        StartCoroutine(spawnEnemy(ArmorSkeletonInterval, ArmorSkeleton));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
