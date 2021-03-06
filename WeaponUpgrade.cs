﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrade : MonoBehaviour {

	public float SelfDestructTimer;
	public float ItemLoiterDuration;
	public GameObject ItemExplosion;
	public GameObject ItemGotExplosion;

	void Start () {
		


	}

	public void OnTriggerEnter2D(Collider2D hit){
		
		if (hit.gameObject.tag == "PLAYERONE") {
			hit.gameObject.GetComponent<PlayerDisparo> ().PlayerUpgradeSystem (+1);
			Instantiate (ItemGotExplosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		}

	}

	// Update is called once per frame
	void Update () {
		SelfDestructTimer += Time.deltaTime;
		if (SelfDestructTimer >= ItemLoiterDuration) {
			Instantiate (ItemExplosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		}

	}
}
