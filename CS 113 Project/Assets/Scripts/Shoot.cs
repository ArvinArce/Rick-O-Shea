using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
	public float bulletSpeed;
	public float fireRate;

	private float nextFire = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Space)) && Time.time > nextFire)
        {
			nextFire = fireRate + Time.time;
            Fire();
        }
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // Destroy the bullet after 2 seconds
        //Destroy(bullet, 2.0f);
    }
}