using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
	public static float movementSpeed;
	public int width;
	public int height;
	public GameObject MovingLevel;
	void Start ()
	{
		movementSpeed = 5.0f;
	}

	// Update is called once per frame
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
<<<<<<< HEAD

		if (Application.loadedLevelName == "Level1"){
			Vector3 direction = new Vector3(0,vertical,0);
			Vector3 finalDirection = new Vector3(horizontal,vertical,5.0f);
			transform.position += direction*movementSpeed*Time.deltaTime;
			transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation
		                                              (finalDirection),Mathf.Deg2Rad*50.0f);

			float widthRel = width / (Screen.width);
			float heightRel= height /(Screen.height); 

			Vector3 viewPos = Camera.main.WorldToViewportPoint (this.transform.position);
			viewPos.x = Mathf.Clamp(viewPos.x, widthRel, 1-widthRel);
			viewPos.y = Mathf.Clamp(viewPos.y, heightRel, 1-heightRel);
			this.transform.position = Camera.main.ViewportToWorldPoint (viewPos);
		}else if (Application.loadedLevelName == "Level2"){
			Vector3 direction = new Vector3(horizontal,vertical,0);
			Vector3 finalDirection = new Vector3(horizontal,vertical,5.0f);
			transform.position += direction*movementSpeed*Time.deltaTime;
			transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation(finalDirection),Mathf.Deg2Rad*30.0f);

			float widthRel = width / (Screen.width);
			float heightRel= height /(Screen.height); 
			
			Vector3 viewPos = Camera.main.WorldToViewportPoint (this.transform.position);
			viewPos.x = Mathf.Clamp(viewPos.x, widthRel, 1-widthRel);
			viewPos.y = Mathf.Clamp(viewPos.y, heightRel, 1-heightRel);
			this.transform.position = Camera.main.ViewportToWorldPoint (viewPos);
		}
		
=======
		Vector3 direction = new Vector3(0,vertical,0);
		Vector3 bank = new Vector3 (horizontal, 0, 3.0f);
		Vector3 finalDirection = new Vector3(horizontal,vertical,3.5f);
		transform.position += direction*movementSpeed*Time.deltaTime;
		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation
		                                              (finalDirection),Mathf.Deg2Rad*100.0f);
	

		float widthRel = width / (Screen.width);
		float heightRel= height /(Screen.height); 

		/*Vector3 viewPos = Camera.main.WorldToViewportPoint (this.transform.position);
		viewPos.x = Mathf.Clamp(viewPos.x, widthRel, 1-widthRel);
		viewPos.y = Mathf.Clamp(viewPos.y, heightRel, 1-heightRel);
		this.transform.position = Camera.main.ViewportToWorldPoint (viewPos);*/
		Vector3 viewPos = transform.position;
		viewPos.y = Mathf.Clamp(viewPos.y, -3, 13);
		transform.position = viewPos;
>>>>>>> master

		if (movementSpeed < 7) {
			movementSpeed = 7;
		}

	}
}
