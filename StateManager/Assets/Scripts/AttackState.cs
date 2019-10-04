using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State {

    int ammo;

	// Use this for initialization
	void Start () {
        ammo = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (ammo <= 0)
        {
            Debug.Log("Out of ammo, changing state to jump...");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Debug.Log("Shoot");
            System.Threading.Thread.Sleep(350);
            ammo--;
        }

	}
}
