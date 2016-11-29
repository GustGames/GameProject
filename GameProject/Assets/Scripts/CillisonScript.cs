using UnityEngine;
using System.Collections;

public class CillisonScript : MonoBehaviour {
	public int height;
<<<<<<< HEAD

=======
	public GameObject Ship;
	public Texture2D textureImage;
	public bool Feedback = false;
>>>>>>> master
	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Astroid(Clone)") {
			Destroy (other.gameObject);
			Debug.Log ("SPEED DOWN");
			FOV.SpeedDown ();
			MoveForward.SpeedAstroidDown ();

		} else if (other.gameObject.name == "SpeedRing(Clone)") {
			Destroy (other.gameObject);
			Debug.Log ("SPEED BOOST");
			FOV.SpeedBoost ();
			MoveForward.SpeedRingBoost ();
<<<<<<< HEAD
		} else if (other.gameObject.name == "MovingLevel") {
			float heightRel= height /(Screen.height);

			//GameObject.Find ("Ship").transform.position = new Vector3 (GameObject.Find ("Ship").transform.position.x, GameObject.Find ("Ship").transform.position.y + 0.25f, GameObject.Find ("Ship").transform.position.z);
			Vector3 wall = this.transform.position;
			wall.y = Mathf.Clamp(wall.y, heightRel, other.transform.position.y);
			this.transform.position = wall;
=======
			Feedback = true;
		} else if (other.gameObject.name == "MovingLevel") {
>>>>>>> master

		} else if (other.gameObject.name == "Pillar(Clone)") {
			MoveForward.SpeedAstroidDown ();
		}
<<<<<<< HEAD

=======
>>>>>>> master
		else {
			Debug.Log ("No Collision");
		}


	}
<<<<<<< HEAD
	

=======

	void OnGUI(){
		if (Feedback == true) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), textureImage);

		}
	}
>>>>>>> master

	/**
	void OnCollisionEnter ( Collision collision ){
		Debug.Log ("Enter Called");

		if (collision.gameObject.name == "MovingLevel") {

		}

		if (collision.gameObject.name == "SpeedRing(Clone)") {
			Destroy (collision.gameObject);
			FOV.SpeedBoost();
			MoveForward.SpeedRingBoost();
		}
		if (collision.gameObject.name == "Astroid(Clone)") {
			Destroy (collision.gameObject);
			FOV.SpeedDown();
			MoveForward.SpeedAstroidDown();
		}
	}**/
}
