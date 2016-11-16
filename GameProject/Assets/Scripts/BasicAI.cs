using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
	public GameObject player;
	public float speed = 20f;

	public Transform target;
	
	void MoveToRing(){
		transform.LookAt (GameObject.Find("SpeedRing(Clone)").transform.position);
		transform.position += transform.forward*speed*Time.deltaTime;
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("Entered Next Function");
		if(other.gameObject.name == "SpeedRing(Clone)"){
			transform.position += transform.forward *speed* Time.deltaTime;
			Debug.Log("Got it");
		}

	}

	void calcuateVec(){
		/**
		 * getting the vector between two points
		 * in this case speed ring and AI
		 **/

		Vector3 targetDir = target.position - transform.position;
		float angel = Vector3.Angle (targetDir, transform.forward);

		if (angel > 50.0f) {
			print ("close");
		}
	}
	
	// Update is called once per frame
	void Update () {
		MoveToRing ();
		calcuateVec ();
	}
}
