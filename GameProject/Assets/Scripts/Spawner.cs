using UnityEngine;
using System.Collections;
public class Spawner : MonoBehaviour {

	public GameObject SpeedRing;
	public GameObject Astroid;
	public GameObject PlayerShip;
	public GameObject MovingLevel;

	
	void Start () {
		InvokeRepeating ("SpawnSpeedRing", 5, 5);
		InvokeRepeating ("SpawnAstroid", 1, 1);

	}

	void Update () {

	}

	void SpawnSpeedRing()
	{
		GameObject SpeedRingClone = Instantiate (SpeedRing, new Vector3 (Random.Range (MovingLevel.transform.position.x-30,MovingLevel.transform.position.x+30), Random.Range (-MovingLevel.transform.position.y-30, MovingLevel.transform.position.y+15), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		SpeedRingClone.transform.parent = GameObject.Find("MovingLevel").transform;
	}
	void SpawnAstroid()
	{

		GameObject AstroidClone = Instantiate (Astroid, new Vector3 (Random.Range (MovingLevel.transform.position.x-30,MovingLevel.transform.position.x+30), Random.Range (-MovingLevel.transform.position.y-30, MovingLevel.transform.position.y+15), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		AstroidClone.transform.parent = GameObject.Find("MovingLevel").transform;
	}
}