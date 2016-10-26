using UnityEngine;
using System.Collections;

public class CillisonScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Astroid(Clone)") {
			Debug.Log ("FUCK YOUR DREAMS");
			Destroy (other.gameObject);
			Debug.Log ("SPEED DOWN");
			FOV.SpeedDown ();
			MoveForward.SpeedAstroidDown ();
		} else if (other.gameObject.name == "SpeedRing(Clone)") {
			Debug.Log ("FUCK YOUR DREAMS");
			Destroy (other.gameObject);
			Debug.Log ("SPEED BOOST");
			FOV.SpeedBoost ();
			MoveForward.SpeedRingBoost ();
		} else {
			Debug.Log ("No Collision");
		}
	}
	/**
	void OnCollisionEnter ( Collision collision ){
		Debug.Log ("Enter Called");


	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Astroid(Clone)") {
			Debug.Log ("FUCK YOUR DREAMS");
			Destroy (other.gameObject);
			Debug.Log ("SPEED DOWN");
			FOV.SpeedDown ();
			MoveForward.SpeedAstroidDown ();
		} else if (other.gameObject.name == "SpeedRing(Clone)") {
			Debug.Log ("FUCK YOUR DREAMS");
			Destroy (other.gameObject);
			Debug.Log ("SPEED BOOST");
			FOV.SpeedBoost ();
			MoveForward.SpeedRingBoost ();
		} else {
			Debug.Log ("No Collision");
		}
	}**/
}
