using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour {

	bool ForwardFace;
	public float SpeedForward;
	public float SpeedMnvrMultiplier;
	public float TotalRotation;

//	public object PlayerShadow;

//	public float RotSpeed;
//	public int RotDuration = 1;



	void Start () {
		ForwardFace = true;
	}


	void Update () {
//		TotalRotation = (RotSpeed * RotDuration);

		if (ForwardFace == true) {

			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
				transform.Translate (0, SpeedForward, 0, Space.World);
			}
			if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
				transform.Translate (0, -(SpeedForward * SpeedMnvrMultiplier), 0, Space.World);
			}
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate ((SpeedForward * SpeedMnvrMultiplier), 0, 0, Space.World);
			}
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (-(SpeedForward * SpeedMnvrMultiplier), 0, 0, Space.World);
			}
		}

//		if (Input.GetKeyDown (KeyCode.F)) {
//			ForwardFace = !ForwardFace;
//			transform.Rotate (0, 0, TotalRotation);	
//		}
//				
//		if (ForwardFace == false) {
//			if (Input.GetKey (KeyCode.W)) {
//				transform.Translate (0, (SpeedForward * SpeedMnvrMultiplier), 0, Space.World);
//			}
//			if (Input.GetKey (KeyCode.S)) {
//				transform.Translate (0, -(SpeedForward), 0, Space.World);
//			}
//			if (Input.GetKey (KeyCode.D)) {
//				transform.Translate ((SpeedForward * SpeedMnvrMultiplier), 0, 0, Space.World);
//			}
//			if (Input.GetKey (KeyCode.A)) {
//				transform.Translate (-(SpeedForward * SpeedMnvrMultiplier), 0, 0, Space.World);
//			}
//		}
			


		Vector3 posicao = transform.position;
		//if (posicao > 8f) posicao.x = 8f;
		//if (posicao < -8f) posicao.x = -8f;
		posicao.x = Mathf.Clamp (posicao.x, -6f, 6f); //Mathf.Clamp determina valores máximos e mínimos
		posicao.y = Mathf.Clamp (posicao.y, -3.5f, 4f);
		transform.position = posicao;
	}

//		Vector3 posicaosombra = transform.position;
//		posicaosombra (-2f, 4f, 0, Space.World);
//		Vector3 rotacaosombra = transform.rotation;
//		rotacaosombra = gameObject.GetComponentInParent<>

}
