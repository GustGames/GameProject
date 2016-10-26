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

	void SpawnSpeedRing(){
		GameObject SpeedRingClone = Instantiate (SpeedRing, new Vector3 (Random.Range (-8, 8), Random.Range (-5, 5), (PlayerShip.transform.position.z + 250)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		if (Application.loadedLevelName == "Level1") {
			SpeedRingClone.transform.parent = GameObject.Find("MovingLevel").transform;
		}
	}
	void SpawnAstroid()	{

		GameObject AstroidClone = Instantiate (Astroid, new Vector3 (Random.Range (-8, 8), Random.Range (-5, 5), (PlayerShip.transform.position.z + 250)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		if (Application.loadedLevelName == "Level1") {
			AstroidClone.transform.parent = GameObject.Find ("MovingLevel").transform;
		}
	}
}