using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathExplosion : MonoBehaviour {

	public float DeathExplosionDuration;
	public int ExplosionDamageDone;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, DeathExplosionDuration);
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnTriggerEnter2D(Collider2D hit){

		//		if (hit.gameObject.tag == "EnemyChopper") {
		//			hit.gameObject.GetComponent<EnemyChopperAI> ().EnemyDamageTaken (-1);
		//			Destroy (gameObject);
		//		}
		//
		//		if (hit.gameObject.tag == "EnemySuperChopper") {
		//			hit.gameObject.GetComponent<EnemySuperChopperAI> ().EnemyDamageTaken (-1);
		//			Destroy (gameObject);
		//		}
		//
		//		if (hit.gameObject.tag == "EnemyShip") {
		//			hit.gameObject.GetComponent<EnemyShipAI> ().EnemyDamageTaken (-1);
		//			Destroy (gameObject);
		//		}
		//		if (hit.gameObject.tag == "EnemyMissile") {
		//			hit.gameObject.GetComponent<BossMissile> ().MissileDamageTaken (-1);
		//			Destroy (gameObject);
		//		}
		//		if (hit.gameObject.tag == "EnemyBoss") {
		//			hit.gameObject.GetComponent<BossScript> ().BossDamageTaken (-1);
		//			Destroy (gameObject);
		//		}

		if (hit.gameObject.tag == "Type0Mk1Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType0Mk1Hitbox> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}
		if (hit.gameObject.tag == "Type0Mk2Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType0Mk2Hitbox> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}		
		if (hit.gameObject.tag == "Type0Mk3Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType0Mk3Hitbox> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}
		if (hit.gameObject.tag == "Type0Mk4Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType0Mk4Hitbox> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}		

		if (hit.gameObject.tag == "Type1Mk1Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType1Mk1and3AI> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}

		if (hit.gameObject.tag == "Type1Mk2Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType1Mk2and4AI> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}

		if (hit.gameObject.tag == "Type1Mk3Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType1Mk1and3AI> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}

		if (hit.gameObject.tag == "Type1Mk4Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType1Mk2and4AI> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}

		if (hit.gameObject.tag == "Type2Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType2AI> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}

		if (hit.gameObject.tag == "Type3Enemy") {
			hit.gameObject.GetComponent<SpaceEnemyType3AI> ().EnemyDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}
		if (hit.gameObject.tag == "EnemyMissile") {
			hit.gameObject.GetComponent<BossMissile> ().MissileDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}
		if (hit.gameObject.tag == "EnemyBoss") {
			hit.gameObject.GetComponent<BossScript> ().BossDamageTaken (-ExplosionDamageDone);
			Destroy (gameObject);
		}
		//		if (hit.gameObject.tag == "Type4Enemy") {
		//			hit.gameObject.GetComponent<SpaceEnemyType4AI> ().EnemyDamageTaken (-1);
		//			Destroy (gameObject);
		//		}
	}

}