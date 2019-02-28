using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisparo : MonoBehaviour {

	public Rigidbody2D Tiro;
	public Transform PlayerMuzzleBasicCenter;
	public Transform PlayerMuzzleUpgradeOneLeft;
	public Transform PlayerMuzzleUpgradeOneRight;
	public Transform PlayerMuzzleUpgradeTwoLeft;
	public Transform PlayerMuzzleUpgradeTwoRight;
	public float ForcaTiro;
	public float Reload;
	public float RateOfFire;
	public int UpgradeLevel;

	// Use this for initialization
	void Start () {
		UpgradeLevel = 0;
	}

	// Update is called once per frame
	void Update () {
		if (UpgradeLevel == 0) {
			PlayerStandardFire ();
		}
		if (UpgradeLevel == 1) {
			PlayerWeaponUpgradeOneFire ();
		}
		if (UpgradeLevel == 2) {
			PlayerWeaponUpgradeTwoFire ();
		}
		if (UpgradeLevel > 2) {
			HUD.pontuacao += 10;
			UpgradeLevel = 2;
		}
	}


	public void PlayerUpgradeSystem(int upgrade) {
		UpgradeLevel += upgrade;

	}
	public void PlayerStandardFire() {
		Reload += Time.deltaTime;
		if (Reload >= RateOfFire) {

			if (Input.GetKey (KeyCode.Space)) {
				Rigidbody2D bala = Instantiate (Tiro, PlayerMuzzleBasicCenter.position, PlayerMuzzleBasicCenter.rotation) as Rigidbody2D;
				bala.AddForce (PlayerMuzzleBasicCenter.up * ForcaTiro);
				Reload = 0;
			}
		}
	}
	public void PlayerWeaponUpgradeOneFire() {
//		gameObject.GetComponentsInChildren<PlayerBasicMuzzle>().enabled =false;
		Reload += Time.deltaTime;
		if (Reload >= RateOfFire) {

			if (Input.GetKey (KeyCode.Space)) {
				Rigidbody2D balaLeft = Instantiate (Tiro, PlayerMuzzleUpgradeOneLeft.position, PlayerMuzzleUpgradeOneLeft.rotation) as Rigidbody2D;
				balaLeft.AddForce (PlayerMuzzleUpgradeOneLeft.up * ForcaTiro);
				Reload = 0;
				Rigidbody2D balaRight = Instantiate (Tiro, PlayerMuzzleUpgradeOneRight.position, PlayerMuzzleUpgradeOneRight.rotation) as Rigidbody2D;
				balaRight.AddForce (PlayerMuzzleUpgradeOneRight.up * ForcaTiro);
				Reload = 0;
			}
		}
	}
	public void PlayerWeaponUpgradeTwoFire() {
		Reload += Time.deltaTime;
		if (Reload >= RateOfFire) {

			if (Input.GetKey (KeyCode.Space)) {
				Rigidbody2D balaLeft = Instantiate (Tiro, PlayerMuzzleUpgradeOneLeft.position, PlayerMuzzleUpgradeOneLeft.rotation) as Rigidbody2D;
				balaLeft.AddForce (PlayerMuzzleUpgradeOneLeft.up * ForcaTiro);
				Reload = 0;
				Rigidbody2D balaRight = Instantiate (Tiro, PlayerMuzzleUpgradeOneRight.position, PlayerMuzzleUpgradeOneRight.rotation) as Rigidbody2D;
				balaRight.AddForce (PlayerMuzzleUpgradeOneRight.up * ForcaTiro);
				Reload = 0;

				Rigidbody2D bala2Left = Instantiate (Tiro, PlayerMuzzleUpgradeTwoLeft.position, PlayerMuzzleUpgradeTwoLeft.rotation) as Rigidbody2D;
				bala2Left.AddForce (PlayerMuzzleUpgradeTwoLeft.up * ForcaTiro);
				Reload = 0;
				Rigidbody2D bala2Right = Instantiate (Tiro, PlayerMuzzleUpgradeTwoRight.position, PlayerMuzzleUpgradeTwoRight.rotation) as Rigidbody2D;
				bala2Right.AddForce (PlayerMuzzleUpgradeTwoRight.up * ForcaTiro);
				Reload = 0;
			}
		}
	}
}
