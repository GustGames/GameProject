using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 6.5f);
	}
	
	// Update is called once per frame
	void Update () 
	{	

		transform.Rotate(0, Time.deltaTime, 0, Space.Self);
	}
}
