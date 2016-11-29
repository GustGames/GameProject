using UnityEngine;
using System.Collections;

public class SkyBoxScript : MonoBehaviour {
	public Object objectToFollow;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.position += transform.forward*MoveForward.speed*Time.deltaTime;		
	}
}
