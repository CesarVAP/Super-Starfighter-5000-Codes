using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerLiveSystem : MonoBehaviour {

//	public GameObject Player;
//	public bool PlayerIsDead;
//	public int PlayerLives = 5;
//	public float TimeToRespawn = 4;
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//
//	public void Respawn() {
//		Instantiate (Player);
//		HUD.NumeroDeVidas = PlayerLives;
//	}
//
//	public void DeathDetect() {
//		if (Player.GetComponent<PlayerHealthSystem> ().PlayerCurrentHealth <= 0) {
//			PlayerIsDead = true;
//			print ("PlayerIsDead");
//			Invoke ("Respawn", TimeToRespawn);
//		}
//	}

	public Transform PlayerChopper;
	public int PlayerLives;
	public GameObject Player;
	public GameObject GameOverMessage;
	public GameObject GameHUD;
//	public float RespawnTimer;
//	public float RespawnMoment;

	void Start () {
		Instantiate (PlayerChopper, gameObject.transform.position, Quaternion.identity);
		Player = GameObject.FindGameObjectWithTag ("PLAYERONE");
		GameOverMessage.SetActive (false);


	}
	void Update () {
		HUD.NumeroDeVidas = PlayerLives;
		if (Player == null && PlayerLives >= 1) {
			Respawn ();
		}


		if (Player == null && PlayerLives == 0) {
			Invoke ("GameOver", 3);
			if (Input.GetKeyDown (KeyCode.Backspace)) {
				SceneManager.LoadScene (0);
				Time.timeScale = 1;
			}
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene (1);
				Time.timeScale = 1;
			}
		}
	}

//	public void DeathCheck ()
//	{
//		if (Player == null) {
//			if (Player
//		}
//	}

	public void Respawn () {
		PlayerLives--;
		Instantiate (PlayerChopper, gameObject.transform.position, Quaternion.identity);
		Player = GameObject.FindGameObjectWithTag ("PLAYERONE");
	}
	public void GameOver () {
		Time.timeScale = 0;
		GameOverMessage.SetActive (true);
		GameHUD.SetActive (false);
	}
}
