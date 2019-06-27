using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchWeapon : MonoBehaviour 
{
    
    public GameObject weapon1;
    public GameObject weapon2;
	// Use this for initialization
	void Start () {
        weapon1.SetActive(true);
        weapon2.SetActive(false);
	}
	
	void Update () {
        if (Input.GetKeyDown("q"))
        {
            switchW();
        }
	}

    void switchW () {
        if (weapon1.activeSelf) {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
        }
        else {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
        }
    }
}
