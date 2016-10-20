using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform objectToFollow;
	public Vector3 movementRatio = Vector3.one;

	// Use this for initialization
	void Start () {
		//needs to start behind the player

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = objectToFollow.position;
		newPosition.x *= movementRatio.x;
		newPosition.y *= movementRatio.y;
		newPosition.z = transform.position.z;
		transform.position = newPosition;
	}
}
