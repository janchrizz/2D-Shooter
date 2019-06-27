using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour {

    public float offset;
    private float timeBetweenShots;
    public float startTimeBtwShots;
    public GameObject bullet;
    public GameObject bulletEffect;
    public Transform point;

	void Update () {
       
 
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + offset);
        if (timeBetweenShots <= 0)
        {
                
                Instantiate(bulletEffect, point.position, Quaternion.identity);
                Instantiate(bullet, point.position, point.rotation);



                timeBetweenShots = startTimeBtwShots;

        }
        else {
            timeBetweenShots -= Time.deltaTime;
        }
	}
}
