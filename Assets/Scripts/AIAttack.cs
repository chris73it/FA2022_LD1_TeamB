using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : MonoBehaviour
{
    public AIChase chase;
    public Melee melee;
    public int damage;
    public float attackRate;
    public GameObject weapon, player;
    public Transform weaponTransform;


    void Start()
    {
        player = GameObject.Find("Player");
        melee.damage = damage;
        melee.rate = attackRate;
    }

    void Update()
    {
        Animation();

        if (weapon != null)
        {
            if (chase.distance < 4)
            {
                weapon.SetActive(true);
            }
            else
            {
                weapon.SetActive(false);
            }
        }
    }

    void Animation()
    {
        Vector2 dir = (player.transform.position - transform.position).normalized;
        float angle = -1 * Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg; //find angle in degrees from enemy to player
        weaponTransform.rotation = Quaternion.AngleAxis(angle, Vector3.back);
    }
}
