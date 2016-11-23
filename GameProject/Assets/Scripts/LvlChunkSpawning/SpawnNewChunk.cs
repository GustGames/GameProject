using UnityEngine;
using System.Collections;

public class SpawnNewChunk : MonoBehaviour {

	GameObject ship;
	public GameObject archChunk;
	public GameObject tunnelChunk;
	public GameObject blankFloorChunk;


	// Use this for initialization
	void Start () {
		ship = GameObject.Find ("Ship");

		int chance = Random.Range (0, 10);
		if(chance < 3){
			Invoke ("spawnArchChunk", 0.5f);
		}
		else if (chance < 7){
			Invoke ("spawnTunnelChunk", 0.5f);
		}
		else{
			Invoke ("spawnBlankFloorChunk", 0.5f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(ship.transform.position.z > transform.position.z + 200)
		{
			Destroy (gameObject);
		}
	}

	void spawnArchChunk(){
		Instantiate (archChunk, new Vector3(transform.position.x, transform.position.y, (transform.position.z + 239)), Quaternion.Euler (270, 180, 0));
		Debug.Log ("SPAWN ARCH.");
	}

	void spawnTunnelChunk(){
		Instantiate (tunnelChunk, new Vector3((transform.position.x), transform.position.y, (transform.position.z + 239)), Quaternion.Euler (0, 0, 0));
		Debug.Log ("SPAWN TUNNEL.");
	}

	void spawnBlankFloorChunk(){
		Instantiate (blankFloorChunk, new Vector3((transform.position.x), transform.position.y, (transform.position.z + 239)), Quaternion.Euler (0, 0, 0));
		Debug.Log ("SPAWN BLANK FLOOR.");
	}
}
