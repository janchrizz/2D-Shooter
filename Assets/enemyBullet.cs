using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour {
    public float speed;
    public float lifeTime;
    public int damage;
    public float knockback;
    public float distance;
    public LayerMask isSolid;
    public GameObject bulletEffect;
    

	// Use this for initialization
	void Start () {
        Invoke("DestroyProjectile", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.forward, distance, isSolid);
        if (hitInfo.collider != null)
        {

            if (hitInfo.collider.CompareTag("Player"))
            {
                hitInfo.collider.GetComponent<PlayerControl>().TakeDamage(damage);
                DestroyProjectile();
            }

        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
	}

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
