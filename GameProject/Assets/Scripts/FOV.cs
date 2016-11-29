using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {

	public float fov = 90f;
	public bool warp,startwarp = false;
	public static bool sboost = false;
	// Use this for initialization

	void Start (){
		Camera.main.fieldOfView = 170;		 
		warp = false;

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space") && ProgressBar.percent >= 100 ) {
			warp = true;
			sboost = false;
		}
		if (warp == true) {
			Warp ();
		} 	//Restores the FOV back to its original value when it's above it. (Like when SpeedBoost is called.)

		if (Camera.main.fieldOfView >= 175) {
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
			}

		if (startwarp == false) {
			Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 40, 2 * Time.deltaTime);
			if (Camera.main.fieldOfView <= 70)
			{
				Camera.main.fieldOfView = 70;
				startwarp = true;
			}
		}
		if (sboost == true && warp == false) {
			Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 85, 3 * Time.deltaTime);

		} else if (sboost == false && startwarp == true && warp == false) {
			Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 40, 1 * Time.deltaTime);
			if (Camera.main.fieldOfView <= 70)
			{
				Camera.main.fieldOfView = 70;
			}
		}




	}

	void Warp(){
		Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 220, 1 * Time.deltaTime);		 
	}

	public static void SpeedBoost(){
		sboost = true;

	}
	public static void SpeedDown(){
		sboost = false;
	}
}
