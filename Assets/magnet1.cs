using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet1 : MonoBehaviour
{

    public float offset;
    private float timeBetweenShots;
    public float startTimeBtwShots;
    public GameObject bullet;
    public GameObject bulletEffect;
    public GameObject counterEffect;

    public Transform point;
    private readonly string[] solution = { "x", "c", "x" };
    private int sequence = 0;
    private float timer = 0;

    void Start() 
    {
        counterEffect.SetActive(false);
    }
    void Update()
    {

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + offset);

        timer += Time.deltaTime;

        if(timer > 1) 
        {
            timer = 0;
            sequence = 0;
            counterEffect.SetActive(false);

        }

        if (Input.GetKeyDown(solution[sequence]))
        {
            counterEffect.SetActive(true);
            
            timer = 0;
            sequence += 1;
            if (sequence == solution.Length)
            {
                sequence = 0;
                Instantiate(bulletEffect, point.position, Quaternion.identity);
                Instantiate(bullet, point.position, point.rotation);
            }

        }
        else if (Input.anyKeyDown)
        {
            timer = 0;
            sequence = 0;
        }

        


       
     }
        
    }

