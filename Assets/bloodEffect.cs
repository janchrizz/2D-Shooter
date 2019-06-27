using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodEffect : MonoBehaviour {

	public int lifeTime;

	// Use this for initialization
	public void Start () {
		
	}
	
	public void Hide() {
		Debug.Log("lalala");
		gameObject.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		
	}

	public void Appear() {
		Debug.Log("xxx");
		gameObject.SetActive(true);
		Invoke("Hide", lifeTime);
	}
}
