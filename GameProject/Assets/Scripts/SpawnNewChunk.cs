using UnityEngine;
using System.Collections;

public class SpawnNewChunk : MonoBehaviour {

	GameObject ship;
	GameObject thisChunk;
	public GameObject tunnelChunk;


	// Use this for initialization
	void Start () {
		ship = GameObject.Find ("Ship");
		thisChunk = gameObject;
		int chance = Random.Range (0, 10);

		//if(chance > 5){
			Invoke ("SpawnSameChunk", 1);
		//}
		//else{
			//Invoke ("SpawnOtherChunk", 1);
		//}
	}
	
	// Update is called once per frame
	void Update () {
		if(ship.transform.position.z > transform.position.z + 200)
		{
			Destroy (gameObject);
		}
	}

	void SpawnSameChunk(){
		Instantiate (thisChunk, new Vector3(transform.position.x, transform.position.y, (transform.position.z + 239)), Quaternion.Euler (270, 180, 0));
	}

	/*void SpawnOtherChunk(){
		Instantiate (tunnelChunk, new Vector3((transform.position.x - 27), transform.position.y, (transform.position.z + 107)), Quaternion.Euler (270, 180, 0));
	}*/
}
