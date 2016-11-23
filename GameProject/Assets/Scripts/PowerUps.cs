using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PowerUps : MonoBehaviour {
	public Image background;
	public Text Txtprogress;
	[Range(0,100)]
	public int Amount = 0;
	static public int percent;
	public int width;
	public int height;
	public float speed;
	public float amount;
	public GameObject Ship;
	public GameObject Blast;
	public GameObject Emp;
	public bool create = false;
	public bool grow = false;
	// Use this for initialization
	void Start () {
		speed = 100;
	}
	
	// Update is called once per frame
	void Update () {
		background.fillAmount = amount;
		Txtprogress.text = string.Format ("{0} %", percent);
		FillBar ();
		Shield ();
		EMP ();

	}
	void Shield (){
		
		if (percent > 0 && Input.GetKey ("q")) {
			
			percent -= 1;
			speed -= 1;
			//background.fillAmount = amount;
			//Txtprogress.text = string.Format ("{0} %", percent);
			if (create == false) {
				GameObject BlastClone = Instantiate (Blast, new Vector3 (Ship.transform.position.x, Ship.transform.position.y, Ship.transform.position.z + 1), Quaternion.Euler (0, 0, 0)) as GameObject;
				BlastClone.transform.parent = GameObject.Find ("Ship").transform;
				create = true;
			}
			if (GameObject.Find ("Blast(Clone)").transform.localScale.y < 7) {
				GameObject.Find ("Blast(Clone)").transform.localScale += new Vector3 (0.4f, 0.4f, 0.4f);
			}
			
		} else if (percent == 0 || !Input.GetKey ("space")) {
			Destroy (GameObject.Find ("Blast(Clone)"));
			create = false;
		} else {
			Debug.Log("done");
		}
	}
	void EMP()
	{
		if (percent == 100 && Input.GetKeyDown("e"))
		{
			percent = 0;
			speed = 0;
			grow = true;
			//background.fillAmount = amount;
			//Txtprogress.text = string.Format ("{0} %", percent);
			if (create == false)
			{
				GameObject emp = Instantiate (Emp, new Vector3 (Ship.transform.position.x, Ship.transform.position.y, Ship.transform.position.z + 1), Quaternion.Euler (0, 0, 0)) as GameObject;
				emp.transform.parent = GameObject.Find ("Ship").transform;
				create = true;
			}
		 	
		}
		if (grow == true) {
			GameObject.Find ("EMP(Clone)").transform.localScale += new Vector3 (0.4f, 0.4f, 0.4f);
			if (GameObject.Find ("EMP(Clone)").transform.localScale.y  >= 20)
			{
				Destroy (GameObject.Find ("EMP(Clone)"));
				create = false;
				grow = false;
			}
				
		}
	}
	void FillBar()
	{
		amount = (speed / 100.0f);
		percent = (int)speed/1;
		
		if (percent < 100 && !Input.GetKey("space")) {

			speed += 0.4f;
			//background.fillAmount = amount;
		//	Txtprogress.text = string.Format ("{0} %", percent);
		}
		else if (percent == 100) {
			percent = 100;
			//background.fillAmount = amount;
			//Txtprogress.text = string.Format ("{0} %", percent);
		}
		/*Vector2 prog = this.transform.position;
		prog.y = Mathf.Clamp(prog.y, Screen.height-100, Screen.height);
		prog.x = Mathf.Clamp(prog.x, Screen.width-900, Screen.width);
		this.transform.position = prog;*/
	}
}
