using UnityEngine;
using System.Collections;
public class Spawner : MonoBehaviour {

	public GameObject SpeedRing;
	public GameObject Astroid;
	public GameObject PlayerShip;
	public GameObject MovingLevel;
	public GameObject Pillar;

	
	void Start () {
		InvokeRepeating ("SpawnSpeedRing", 1, 5);
		InvokeRepeating ("SpawnSpeedRing", 1, 2.5f);
		InvokeRepeating ("SpawnAstroid", 1, 0.3f);
		InvokeRepeating ("SpawnAstroid", 1, 0.6f);
		InvokeRepeating ("SpawnPillar", 1, 2);
	}




	void SpawnSpeedRing()
	{
		GameObject SpeedRingClone1 = Instantiate (SpeedRing, new Vector3 (Random.Range (MovingLevel.transform.position.x+5,MovingLevel.transform.position.x+30), Random.Range (MovingLevel.transform.position.y+5, MovingLevel.transform.position.y+15), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (0, 0, 0)) as GameObject;
		GameObject SpeedRingClone2 = Instantiate (SpeedRing, new Vector3 (Random.Range (MovingLevel.transform.position.x-5,MovingLevel.transform.position.x-30), Random.Range (MovingLevel.transform.position.y-5, MovingLevel.transform.position.y-15), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (0, 0, 0)) as GameObject;
		SpeedRingClone1.transform.parent = GameObject.Find("MovingLevel").transform;
		SpeedRingClone2.transform.parent = GameObject.Find("MovingLevel").transform;
	}
	void SpawnAstroid()
	{
		GameObject AstroidClone1 = Instantiate (Astroid, new Vector3 (Random.Range (MovingLevel.transform.position.x -30,MovingLevel.transform.position.x+30), Random.Range (MovingLevel.transform.position.y-30, MovingLevel.transform.position.y+30), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		GameObject AstroidClone2 = Instantiate (Astroid, new Vector3 (Random.Range (MovingLevel.transform.position.x+30,MovingLevel.transform.position.x-30), Random.Range (MovingLevel.transform.position.y+30, MovingLevel.transform.position.y-30), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		AstroidClone1.transform.parent = GameObject.Find("MovingLevel").transform;
		AstroidClone2.transform.parent = GameObject.Find("MovingLevel").transform;

	}
	void SpawnPillar()
	{

		GameObject PillarClone = Instantiate (Pillar, new Vector3 (Random.Range (MovingLevel.transform.position.x -5,MovingLevel.transform.position.x+5), Random.Range (MovingLevel.transform.position.y+5, MovingLevel.transform.position.y+5), Random.Range(PlayerShip.transform.position.z + 400, PlayerShip.transform.position.z + 500)), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f))) as GameObject;
		PillarClone.transform.parent = GameObject.Find("MovingLevel").transform;


	}

	/**void SpawnSpeedRing()
	{
		float xa = Random.Range (MovingLevel.transform.position.x+10, MovingLevel.transform.position.x + 30);
		float xb = Random.Range (MovingLevel.transform.position.x-10, MovingLevel.transform.position.x - 30);

		float ya = Random.Range (MovingLevel.transform.position.y+10, MovingLevel.transform.position.y + 30);
		float yb= Random.Range (MovingLevel.transform.position.y-10, MovingLevel.transform.position.y - 30);
		//GameObject SpeedRingClone = Instantiate (SpeedRing, new Vector3 (Random.Range (MovingLevel.transform.position.x-30,MovingLevel.transform.position.x+30), Random.Range (-MovingLevel.transform.position.y-30, MovingLevel.transform.position.y+15), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		GameObject SpeedRingClone = Instantiate (SpeedRing, new Vector3 (Random.Range (xb,xa), Random.Range (yb,ya), Random.Range(PlayerShip.transform.position.z + 250, PlayerShip.transform.position.z + 500)), Quaternion.Euler (-90, 0, 0)) as GameObject;
		SpeedRingClone.transform.parent = GameObject.Find("MovingLevel").transform;
	}**/
}