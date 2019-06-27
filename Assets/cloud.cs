using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour {
    public float lifeTime;
	// Use this for initialization
	void Start () {
        Invoke("destroyCloud", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void destroyCloud()
    {
        Destroy(gameObject);
    }
}
