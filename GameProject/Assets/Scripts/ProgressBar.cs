using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour {
	public Image background;
	public Text Txtprogress;
	[Range(0,100)]
	public int Amount = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float speed = MoveForward.speed;
		float amount = (MoveForward.speed / 500.0f);
		int percent = (int)speed/5;
		background.fillAmount = amount;
		Txtprogress.text = string.Format ("{0} %", percent);
	}
}
