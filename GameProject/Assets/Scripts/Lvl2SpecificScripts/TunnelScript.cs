using UnityEngine;
using System.Collections;

public class TunnelScript : MonoBehaviour {

	public GameObject HorizontalLaser;
	public GameObject VerticalLaser;
	
	void Start () {
		spawnLasers ();

	}
	
	void spawnLasers(){
		GameObject theHorizontalLaser = Instantiate (HorizontalLaser, new Vector3(transform.position.x, (transform.position.y + Random.Range (5, 25)), transform.position.z), Quaternion.Euler (0,0,90)) as GameObject;
		GameObject theVerticalLaser = Instantiate (VerticalLaser, new Vector3((transform.position.x + Random.Range (5, 25)), (transform.position.y + 18) , transform.position.z), Quaternion.Euler (0,0,0)) as GameObject;
		
		theHorizontalLaser.transform.parent = gameObject.transform;
		theVerticalLaser.transform.parent = gameObject.transform;
	}
}
