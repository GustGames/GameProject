using UnityEngine;
using System.Collections;
public class LVL2Spawner : MonoBehaviour {

	public GameObject SpeedRing;
	public GameObject PlayerShip;
	public GameObject FeedBack;
	public Texture2D Red;

	
	void Start () {
		InvokeRepeating ("SpawnSpeedRing", 1, 5);
		InvokeRepeating ("SpawnSpeedRing", 1, 2.5f);
		//Invoke ("SpawnFeedBack", 2);
	}




	void SpawnSpeedRing()
	{
		GameObject SpeedRingClone1 = Instantiate (SpeedRing, new Vector3 ((Random.Range (-5, 5)), (Random.Range (5, 5)), PlayerShip.transform.position.z + 500), Quaternion.Euler (0, 180, 0)) as GameObject;
		SpeedRingClone1.transform.parent = GameObject.Find("Level").transform;
	}

	void SpawnFeedBack()
	{

		//GameObject FeedBackClone = Instantiate (FeedBack) as GameObject;
		//float width = Screen.width;
		//float height = Screen.height;
		//GameObject FeedBackClone = Instantiate (FeedBack, new Vector2(width,height), Quaternion.Euler (0, 0, 0))  as GameObject;
		//GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), Red); 
		//FeedBackClone.transform.parent = GameObject.Find ("Canvas").transform;

		

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