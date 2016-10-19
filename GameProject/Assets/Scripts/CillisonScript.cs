using UnityEngine;
using System.Collections;

public class CillisonScript : MonoBehaviour {
	void OnCollisionEnter ( Collision collision ){
		Debug.Log ("Enter Called");

		if (collision.gameObject.name == "wall") {
			Destroy (collision.gameObject);
		}

		if (collision.gameObject.name == "SpeedRing(Clone)") {
			Destroy (collision.gameObject);
			Debug.Log ("SPEED BOOST");
			FOV.SpeedBoost();
			MoveForward.SpeedRingBoost();
		}
		if (collision.gameObject.name == "Astroid(Clone)") {
			Destroy (collision.gameObject);
			Debug.Log ("SPEED DOWN");
			FOV.SpeedDown();
			MoveForward.SpeedAstroidDown();
		}
	}
}
