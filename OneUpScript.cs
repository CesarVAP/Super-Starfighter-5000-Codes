using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUpScript : MonoBehaviour {

	public float SelfDestructTimer;
	public float ItemLoiterDuration;
	public GameObject ItemExplosion;
	public GameObject ItemGotExplosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SelfDestructTimer += Time.deltaTime;
		if (SelfDestructTimer >= ItemLoiterDuration) {
			Instantiate (ItemExplosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		}
	}

	public void OnTriggerEnter2D(Collider2D hit){

		if (hit.gameObject.tag == "PLAYERONE") {
			GameObject.Find ("PlayerRespawner").GetComponent<PlayerLiveSystem> ().PlayerLives += 1;
			Instantiate (ItemGotExplosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy (gameObject);
		}

	}
}
