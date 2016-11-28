using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
	public GameObject player;
	public float speed = 20f;

	public Transform target;
	
	void MoveToRing(){
		/*
		transform.LookAt (GameObject.Find("SpeedRing(Clone)").transform.position);
		transform.position += transform.forward*speed*Time.deltaTime;

		Vector3 targetDir = target.position - transform.position;
		float angel = Vector3.Angle (targetDir, transform.forward);
		*/

		/*
		 * this prints out on how far away from the target you are
		 */
	}

    void calcuateVec(){
        /**
		 * getting the vector between two points
		 * in this case speed ring and AI
		 **/
		Vector3 speedring = new Vector3((GameObject.Find("SpeedRing(Clone)").transform.position.x - transform.position.x),(GameObject.Find("SpeedRing(Clone)").transform.position.y - transform.position.y) , (GameObject.Find("SpeedRing(Clone)").transform.position.z - transform.position.z));
		Vector3 follow = new Vector3 (transform.forward.x, transform.forward.y, transform.forward.z);
        Debug.Log(speedring);
		Debug.Log (follow);

		speedring.Normalize();
		follow.Normalize();
		Debug.Log(speedring);
		Debug.Log (follow);

		float angle = Vector3.Angle (follow, speedring);

		Debug.Log (angle);

		if (angle > 140f) {
			Destroy(GameObject.Find("SpeedRing(Clone)"));
			print ("DESTROYED");
		} else if (angle < 140f) {
			transform.LookAt (GameObject.Find("SpeedRing(Clone)").transform.position);
			transform.position += transform.forward*speed*Time.deltaTime;
			print ("Infront");
		}

		// Debug.DrawLine(transform.position, GameObject.Find("SpeedRing(Clone)").transform.position, Color.red);
	}
	
	// Update is called once per frame
	void Update (){
		MoveToRing ();
        calcuateVec();
		Debug.DrawLine (transform.position, player.transform.position, Color.green);
        Debug.DrawLine(transform.position, GameObject.Find("SpeedRing(Clone)").transform.position, Color.red);
        //calcuateVec ();
    }
}
