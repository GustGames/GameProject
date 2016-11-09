using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
	//Transform speedRingTrans = ;
	public GameObject player;
	//public GameObject speedRing;


	public float speed = 20f;
	
	void MoveToRing(){
		transform.LookAt (GameObject.Find("SpeedRing(Clone)").transform.position);
		transform.position += transform.forward*speed*Time.deltaTime;
		//transform.Rotate(new Vector3
		
		//if(Vector3.Distance(Transform.position, speedRingTrans.position))
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("Entered Next Function");
		if(other.gameObject.name == "SpeedRing(Clone)"){
			transform.position += transform.forward *speed* Time.deltaTime;
			Debug.Log("Got it");
		}

	}
	
	// Update is called once per frame
	void Update () {
		MoveToRing ();
		//moveToNextRing ();
	}
}
