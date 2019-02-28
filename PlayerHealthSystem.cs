using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour {


	public float PlayerMaxHealth = 5;
	public float PlayerCurrentHealth = 5;
	public float HealingSpeed;
	public float PlayerInvulStart = 0;
	public float PlayerInvulMaxDuration;
	public bool PlayerInvul;
	SpriteRenderer SpriteRend;
	public GameObject PlayerExplosion;
	public float DeathBuffer;

	// Use this for initialization
	void Start () {
		PlayerCurrentHealth = PlayerMaxHealth;
		PlayerInvulStart = 0;
		SpriteRend = GetComponent<SpriteRenderer> ();
		SpriteRend.color = new Color32 (100, 100, 255 , 255);
	}
	
	// Update is called once per frame
	void Update () {
		PlayerDamageTaken (0);

		if (PlayerInvulStart < PlayerInvulMaxDuration) {
			PlayerInvul = true;
		}
		if (PlayerInvul == true) {
			PlayerInvulnerability ();
				SpriteRend = GetComponent<SpriteRenderer> ();
				SpriteRend.color = new Color32 (100, 100, 255 , 255);
		}
		if (PlayerInvulStart >= PlayerInvulMaxDuration) {
			PlayerInvul = false;
		}
		if (PlayerInvul == false) {
			PlayerNormalHealthRegen ();
			SpriteRend = GetComponent<SpriteRenderer> ();
			SpriteRend.color = new Color32 (255, 255, 255 , 255);
		}


		HUD.PlayerHP = PlayerCurrentHealth;
		if(PlayerCurrentHealth <= 0) {
			HUD.PlayerHP = 0;
		}
	}

	public void PlayerDamageTaken(float DMG) {
		PlayerCurrentHealth += DMG;

		if (PlayerCurrentHealth >= PlayerMaxHealth) {
			PlayerCurrentHealth = PlayerMaxHealth;
		}

		if (PlayerMaxHealth < 1) {
			PlayerMaxHealth = 1.0f;
		}

		if (PlayerCurrentHealth <= 0) {
			PlayerCurrentHealth = 0;
			Destroy (gameObject, DeathBuffer);
			Instantiate (PlayerExplosion, gameObject.transform.position, gameObject.transform.rotation);
		}
	}
	public void PlayerNormalHealthRegen() {
		if (PlayerCurrentHealth < PlayerMaxHealth) {
			PlayerCurrentHealth += (HealingSpeed * Time.deltaTime / 2.0f);


		}
	}
	public void PlayerInvulnerability() {
		PlayerInvulStart += Time.deltaTime;
		if (PlayerCurrentHealth < PlayerMaxHealth) {
			PlayerCurrentHealth += (HealingSpeed * Time.deltaTime * 100.0f);

		}
	}
}
