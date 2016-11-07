using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
	public static float movementSpeed;
	public int width;
	public int height;
	void Start ()
	{
		movementSpeed = 5.0f;
	}

	// Update is called once per frame
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(0,vertical,0);
		Vector3 finalDirection = new Vector3(horizontal,vertical,5.0f);
		transform.position += direction*movementSpeed*Time.deltaTime;
		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation
		                                              (finalDirection),Mathf.Deg2Rad*300.0f);

		float widthRel = width / (Screen.width);
		float heightRel= height /(Screen.height); 

		Vector3 viewPos = Camera.main.WorldToViewportPoint (this.transform.position);
		viewPos.x = Mathf.Clamp(viewPos.x, widthRel, 1-widthRel);
		viewPos.y = Mathf.Clamp(viewPos.y, heightRel, 1-heightRel);
		this.transform.position = Camera.main.ViewportToWorldPoint (viewPos);

		if (movementSpeed < 7) {
			movementSpeed = 7;
		}

	}
}
