using UnityEngine;
using System.Collections;

public class CillisonScript : MonoBehaviour {
	public int height;
	public GameObject Ship;
	public Texture2D textureImage;
	public Texture2D textureImage1;
	public bool FeedbackGreen = false;
	public bool FeedbackRed = false;
	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.name == "Astroid(Clone)") {
			Destroy (other.gameObject);
			Debug.Log ("SPEED DOWN");
			FOV.SpeedDown ();
			MoveForward.SpeedAstroidDown ();
			FeedbackRed = true;
			StartCoroutine(Red());
		} else if (other.gameObject.name == "SpeedRing(Clone)") {
			Destroy (other.gameObject);
			Debug.Log ("SPEED BOOST");
			FOV.SpeedBoost ();
			MoveForward.SpeedRingBoost ();
			FeedbackGreen = true;
			StartCoroutine(Green());
		} else if (other.gameObject.name == "MovingLevel") {

		} else if (other.gameObject.name == "Pillar(Clone)") {
			MoveForward.SpeedAstroidDown ();
			FeedbackRed = true;
			StartCoroutine(Red());
		}
		else {
			Debug.Log ("No Collision");
		}


	}
	IEnumerator Green() {

		yield return new WaitForSeconds (0.15f);
		if (FeedbackGreen == true) {
			FeedbackGreen = false;
		}
	}
	IEnumerator Red() {
		
		yield return new WaitForSeconds (0.15f);
		 if (FeedbackRed == true) {
			FeedbackRed = false;
		}
	}


	void OnGUI(){
		if (FeedbackGreen == true) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), textureImage);
		} 
		else if (FeedbackRed == true) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), textureImage1);
		}
	}

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
