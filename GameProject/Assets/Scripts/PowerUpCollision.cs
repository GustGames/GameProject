using UnityEngine;
using System.Collections;

public class PowerUpCollision : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Astroid(Clone)") {
			Destroy (other.gameObject);
		} else if (other.gameObject.name == "Pillar(Clone)") {
			Destroy (other.gameObject);

		}
		else if (other.gameObject.name == "SpeedRing(Clone)") {
			Destroy (other.gameObject);
			
		}

	}
	
	
	
	/**
	void OnCollisionEnter ( Collision collision ){
		Debug.Log ("Enter Called");

		if (collision.gameObject.name == "MovingLevel") {

		}

		if (collision.gameObject.name == "SpeedRing(Clone)") {
			Destroy (collision.gameObject);
			FOV.SpeedBoost();
			MoveForward.SpeedRingBoost();
		}
		if (collision.gameObject.name == "Astroid(Clone)") {
			Destroy (collision.gameObject);
			FOV.SpeedDown();
			MoveForward.SpeedAstroidDown();
		}
	}**/
}
