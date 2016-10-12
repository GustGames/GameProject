using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public static float speed = 30.0f;
	public static float standardSpeed = 100.0f;
	public  float acceleration = 0.1f;
	
	// Update is called once per frame
	void Update () {

		if (speed < standardSpeed) {
			speed  += acceleration;			//Increasing speed.
		}


		transform.position += transform.forward*speed*Time.deltaTime;		//Actual movement.
		if (speed >= 50) {
		}
	}

	public static void SpeedRingBoost() 
	{
		Debug.Log ("BOOST IN SPEED!");
		speed += 50.0f;
		ShipMovement.movementSpeed += 1.0f;
		print (ShipMovement.movementSpeed);
		print (speed);
	}

}