using UnityEngine;
using System.Collections;
public class Spawner : MonoBehaviour {

	public GameObject SpeedRing;
	public GameObject PlayerShip;
	
	void Start () {
		InvokeRepeating ("SpawnSpeedRing", 5, 5);
		SpawnSpeedRing();

	}

	void Update () {
	
	}

	void SpawnSpeedRing()
	{
		Instantiate (SpeedRing, new Vector3 (Random.Range (-8, 8), Random.Range (-5, 5), (PlayerShip.transform.position.z + 250)), Quaternion.Euler (-90, 0, 0));
		Debug.Log ("Speed ring spawned.");
	}
}