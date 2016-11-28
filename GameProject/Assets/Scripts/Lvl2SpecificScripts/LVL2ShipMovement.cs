using UnityEngine;
using System.Collections;

public class LVL2ShipMovement : MonoBehaviour
{
	public static float movementSpeed = 12.0f;
	public int width;
	public int height;

	// Update is called once per frame
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal,vertical,0);
		Vector3 bank = new Vector3 (horizontal, 0, 3.0f);
		Vector3 finalDirection = new Vector3(horizontal,vertical,3.5f);
		transform.position += direction*movementSpeed*Time.deltaTime;
		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation
		                                              (finalDirection),Mathf.Deg2Rad*100.0f);
	

		float widthRel = (width / (Screen.width) / 2);
		float heightRel= height /(Screen.height); 

		//SCREEN BOUNDS FOR SHIP MOVEMENT.
		Vector3 viewPos = Camera.main.WorldToViewportPoint (this.transform.position);
		viewPos.x = Mathf.Clamp(viewPos.x, widthRel, 1-widthRel);
		viewPos.y = Mathf.Clamp(viewPos.y, heightRel, 1-heightRel);
		this.transform.position = Camera.main.ViewportToWorldPoint (viewPos);


		/*/Vector3 viewPos = transform.position;
		viewPos.y = Mathf.Clamp(viewPos.y, -3, 13);
		transform.position = viewPos;*/

		if (movementSpeed < 7) {
			movementSpeed = 7;
		}

	}
}
