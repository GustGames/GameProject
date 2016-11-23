using UnityEngine;
using System.Collections;

public class EmpCollision : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Ship") {
			FOV.SpeedDown ();
			MoveForward.SpeedAstroidDown ();

		} 
		
	}
}
