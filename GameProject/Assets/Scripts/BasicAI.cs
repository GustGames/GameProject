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
		Debug.Log ("Fuck Game dev");
		//transform.Rotate(new Vector3
		
		//if(Vector3.Distance(Transform.position, speedRingTrans.position))
	}

	void moveToNextRing(){

	}

	//public GameObject Enemy;
	//BasicEnemy basicenemy;
	// Use this for initialization
	void Start () {

		//speedRing = GameObject.FindGameObjectsWithTag ("SpeedRing");
		//basicenemy = Enemy.GetComponent <BasicEnemy> ();
	}
	
	// Update is called once per frame
	void Update () {
		MoveToRing ();
	}
}
