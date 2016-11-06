using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour {
	public Image background;
	public Text Txtprogress;
	[Range(0,100)]
	public int Amount = 0;
	static public int percent;
	public int width;
	public int height;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float speed = MoveForward.speed;
		float amount = (MoveForward.speed / 300.0f);
		percent = (int)speed/3;
		background.fillAmount = amount;
		if (percent < 100) {
			Txtprogress.text = string.Format ("{0} %", percent);
		}
		if (percent >= 100) {
			percent = 100;
			Txtprogress.text = string.Format ("{0} %", percent);
		}


	}
}
