﻿using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public static float speed;
	public static float standardSpeed = 100.0f;
	public  float acceleration = 0.5f;


	void Start(){
		speed = 30.0f;
	}

	// Update is called once per frame
	void Update () {

		if (speed < standardSpeed) {
			speed  += acceleration;			//Increasing speed.
		}


		transform.position += transform.forward*speed*Time.deltaTime;		//Actual movement.
		if (speed <= 30) {
			speed = 30;
		}
	}

	public static void SpeedRingBoost() 
	{
		speed += 50.0f;
		ShipMovement.movementSpeed += 1.5f;
	}
	public static void SpeedAstroidDown() 
	{
		speed -= 50.0f;
		ShipMovement.movementSpeed -= 1.5f;
	}
}