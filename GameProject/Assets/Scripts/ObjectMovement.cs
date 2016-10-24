using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {
	public static float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		speed = MoveForward.speed;
		transform.position += transform.up*speed*Time.deltaTime;	
	}
}
