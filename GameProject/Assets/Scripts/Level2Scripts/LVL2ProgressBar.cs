﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LVL2ProgressBar : MonoBehaviour {
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
		float speed = LVL2MoveForward.speed;
		float amount = (LVL2MoveForward.speed / 400.0f);
		percent = (int)speed / 4;
		
		background.fillAmount = amount;
		if (percent < 100) {
			Txtprogress.text = string.Format ("{0} %", percent);
		}
		
		else if (percent >= 100) {
			percent = 100;
			Txtprogress.text = string.Format ("{0} %", percent);
		}

		/**Vector2 prog = this.transform.position;
		prog.y = Mathf.Clamp(prog.y, Screen.height-100, Screen.height);
		prog.x = Mathf.Clamp(prog.x, Screen.width-100, Screen.width);
		this.transform.position = prog;**/
		
		
	}
}