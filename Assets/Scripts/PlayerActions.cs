using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public InputManager input;
    public Gun activeItem;
    public GameObject projectilePrefab;

    public Transform weaponTransform, gunTip;

    float timeSinceActive, reloadTime, reloadDelay;
    bool reloading;

    Vector3 mouseVector, mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animation();
        UseActive();
        Reload();

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //position of cursor in world
        mousePos.z = transform.position.z; //keep the z position consistant, since we're in 2d
        mouseVector = (mousePos - transform.position).normalized;
    }

    void Animation()
    {
        float gunAngle = -1 * Mathf.Atan2(mouseVector.y, mouseVector.x) * Mathf.Rad2Deg; //find angle in degrees from player to cursor
        weaponTransform.rotation = Quaternion.AngleAxis(gunAngle, Vector3.back);
    }

    void UseActive()
    {
        if (timeSinceActive < 3) timeSinceActive += Time.deltaTime;

        if (input.mouseLeft)
        {
            if (activeItem.clipCurrent == 0 && !reloading) { reloadTime = 0; reloading = true; }
            if (timeSinceActive > (activeItem.useRate) && activeItem.clipCurrent > 0 && !reloading) Shoot(activeItem);
        }
    }

    void Shoot(Gun shootThis)
    {
        timeSinceActive = 0;
        shootThis.setClip(shootThis.clipCurrent - shootThis.bulletCount);

        for (int i = 0; i < shootThis.bulletCount; i++)
        {
            Vector3 dir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - gunTip.position).normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            float spread = Random.Range(-shootThis.bulletSpread, shootThis.bulletSpread);

            Quaternion projectileRotation = Quaternion.Euler(new Vector3(0, 0, angle + spread));

            GameObject projectile = (GameObject)GameObject.Instantiate(projectilePrefab, gunTip.position, projectileRotation);
            projectile.GetComponent<Projectile>().Setup(shootThis.damage, shootThis.bulletSpeed, shootThis.speedFallOff, this.gameObject.layer);
        }
        //muzzleFlash.intensity = 2.5f;
        //Cam.Shake((transform.position - gunTip.position).normalized, 1.5f, 0.05f); //call camera shake for recoil
    }

    void Reload()
    {
        if (input.reload && activeItem != null && !reloading)
        {
            if (activeItem.clipCurrent < activeItem.clipSize)
            {
                reloadTime = 0;
                reloading = true;
            }
        }
        if (reloading)
        {
            reloadDelay = activeItem.reloadTime;
            if (activeItem.clipCurrent > 0) reloadDelay -= 0.5f;
            reloadTime += Time.deltaTime;

            //reloadSlider.maxValue = reloadDelay;
            //reloadSlider.value = reloadTime;

            if (reloadTime > reloadDelay)
            {
                if (activeItem.clipCurrent > 0)
                {
                    activeItem.setClip(activeItem.clipSize + activeItem.bulletCount);
                }
                else
                {
                    activeItem.setClip(activeItem.clipSize);
                }
                reloading = false;
                //reloadSlider.value = 0;
            }
        }
    }
}
