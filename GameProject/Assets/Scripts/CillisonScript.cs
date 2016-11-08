using UnityEngine;
using System.Collections;

public class CillisonScript : MonoBehaviour {
	public int height;
	public GameObject Ship;
	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Astroid(Clone)") {
			Destroy (other.gameObject);
			Debug.Log ("SPEED DOWN");
			FOV.SpeedDown ();
			MoveForward.SpeedAstroidDown ();
		} else if (other.gameObject.name == "SpeedRing(Clone)") {
			Destroy (other.gameObject);
			Debug.Log ("SPEED BOOST");
			FOV.SpeedBoost ();
			MoveForward.SpeedRingBoost ();
		} else if (other.gameObject.name == "MovingLevel") {

		} else if (other.gameObject.name == "Pillar(Clone)") {
			MoveForward.SpeedAstroidDown ();
		}


		else {
			Debug.Log ("No Collision");
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
