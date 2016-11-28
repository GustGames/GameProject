﻿using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
	public GameObject player;
	public float speed = 20f;

	public Transform target;
	
	void MoveToRing(){
		transform.LookAt (GameObject.Find("SpeedRing(Clone)").transform.position);
		transform.position += transform.forward*speed*Time.deltaTime;

		Vector3 targetDir = target.position - transform.position;
		float angel = Vector3.Angle (targetDir, transform.forward);


		/*
		 * this prints out on how far away from the target you are
		 */

		if (angel > 90.0f) {
			print ("within");
		} else {
			print("outside");
		}
	}

    void calcuateVec(){
        /**
		 * getting the vector between two points
		 * in this case speed ring and AI
		 **/
        Vector3 speedring = new Vector3(transform.position.x, GameObject.Find("SpeedRing(Clone)").transform.position.x, 0);
        Debug.Log(speedring);
         // Debug.DrawLine(transform.position, GameObject.Find("SpeedRing(Clone)").transform.position, Color.red);
	}
	
	// Update is called once per frame
	void Update (){
		MoveToRing ();
        calcuateVec();
		Debug.DrawLine (transform.position, player.transform.position, Color.green);
        Debug.DrawLine(transform.position, GameObject.Find("SpeedRing(Clone)").transform.position, Color.red);
        //calcuateVec ();
    }
}
