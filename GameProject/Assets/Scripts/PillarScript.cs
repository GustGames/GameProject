using UnityEngine;
using System.Collections;

public class PillarScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale.y < 11) {
			transform.localScale += new Vector3 (0, 0.1f, 0);

		} 
	}
}
