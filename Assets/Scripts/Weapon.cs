using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public bool gamePaused;

    // Update is called once per frame
    void Update()
    {
        gamePaused = PauseMenu.GameIsPaused;
        if(!gamePaused)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        //Shooting Logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
