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
	public void OnValidate()
	{
		float amount = (Amount / 100.0f);

		background.fillAmount = amount;
		Txtprogress.text = string.Format ("{0} %", Amount);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
