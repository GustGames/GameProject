using UnityEngine;
using System.Collections;

public class MovingLevel : MonoBehaviour {
	public float rotationspeed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rotationspeed = ShipMovement.movementSpeed*8.0f;

		transform.RotateAround (transform.up, Input.GetAxis ("Horizontal") * rotationspeed * Mathf.Deg2Rad * Time.deltaTime);


}
}
