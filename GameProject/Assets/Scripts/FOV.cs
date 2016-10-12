using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {

	public float fov = 90f;
	public bool warp,startwarp = false;

	// Use this for initialization

	void Start (){
		Camera.main.fieldOfView = 60;		 
		warp = false;
		startwarp = false;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space") && MoveForward.speed >= 50 ) {
			warp = true;
		}
		if (warp == true) {
			Warp ();
		} else if(Camera.main.fieldOfView > 60){
			Camera.main.fieldOfView -= 0.01f;	//Restores the FOV back to its original value when it's above it. (Like when SpeedBoost is called.)
		}
		if (Camera.main.fieldOfView >= 175) {
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
			}
		}


	void Warp(){
		Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 220, 1 * Time.deltaTime);		 
	}

	public static void SpeedBoost()
	{
		Camera.main.fieldOfView += 5;
	}
}
