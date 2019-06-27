using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public int hitpoint;
    public GameObject death;
    public Transform point;
    private bool triggerCheck;
    private Transform targetChar;
    public float ms;
    public GameObject bullet;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public float offset;
    public int counter;

	private void Start()
	{
        targetChar = GameObject.FindGameObjectWithTag("Player").GetComponent < Transform>();
        counter = 0;
	}
	// Update is called once per frame
	void FixedUpdate () {
        if (triggerCheck) {
            transform.position = Vector2.MoveTowards(transform.position, targetChar.position, ms * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0,offset));
            if (counter % 32 == 0)
            {
                Instantiate(bullet, point.position, point.rotation);
                Instantiate(bullet, point2.position, point2.rotation);
                Instantiate(bullet, point3.position, point3.rotation);
                Instantiate(bullet, point4.position, point4.rotation);
            }

        }
        if(hitpoint <= 0)
        {
            Destroy(gameObject); 
            Instantiate(death, point.position, Quaternion.identity);

        }
        counter += 1;
	}
    public void TakeDamage( int dmg, float knockback) {
        transform.Translate(knockback, 0f, 0f);
        hitpoint -= dmg;
    }
	
    private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.CompareTag("Player")) {
            triggerCheck = true;
        }
	}
	
    private void OnTriggerExit2D(Collider2D collision)
	{
        if (collision.CompareTag("Player")) {
            triggerCheck = false;
        }
	}
}
