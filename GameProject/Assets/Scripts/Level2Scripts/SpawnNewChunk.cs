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

		//CHANCE OF OTHER CHUNK SPAWNING WITH IT



		//SPAWN NEXT CHUNK
		int chance = Random.Range (0, 3);
		if(chance == 0){
			Invoke ("spawnBlankFloorChunk", 0.5f);
		}
		else if (chance == 1){
			Invoke ("spawnTunnelChunk", 0.5f);
		}
		else if (chance == 2){
			Invoke ("spawnArchChunk", 0.5f);
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
		GameObject theArchChunk = Instantiate (archChunk, new Vector3(transform.position.x, transform.position.y, (transform.position.z + 239)), Quaternion.Euler (270, 180, 0)) as GameObject;
		theArchChunk.transform.parent = GameObject.Find ("Level").transform;
	}

	void spawnTunnelChunk(){
		GameObject theTunnelChunk = Instantiate (tunnelChunk, new Vector3((transform.position.x), transform.position.y, (transform.position.z + 239)), Quaternion.Euler (0, 0, 0)) as GameObject;
		theTunnelChunk.transform.parent = GameObject.Find ("Level").transform;
	}

	void spawnBlankFloorChunk(){
		GameObject theFloorChunk = Instantiate (blankFloorChunk, new Vector3((transform.position.x), transform.position.y, (transform.position.z + 239)), Quaternion.Euler (0, 0, 0)) as GameObject;
		theFloorChunk.transform.parent = GameObject.Find ("Level").transform;
	}
}
