using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public static float speed = 30.0f;
	public static float standardSpeed = 50.0f;
	public  float acceleration = 0.1f;
	
	// Update is called once per frame
	void Update () {

		if (speed < standardSpeed) {
			speed  += acceleration;			//Increasing speed.
		}
		if (speed > standardSpeed) {
			speed -= 0.2f;						//If speed is above the standardSpeed, deccelerate until it is not.
		}

		transform.position += transform.forward*speed*Time.deltaTime;		//Actual movement.
		if (speed >= 50) {
			print("PRESS SPACE TO WARP");
		}
	}

	public static void SpeedRingBoost() 
	{
		Debug.Log ("BOOST IN SPEED!");
		speed += 90.0f;
	}

}