using UnityEngine;
using System.Collections;

public class FeedBackScript : MonoBehaviour {

	public Texture2D textureImage;
	
	void OnGUI(){
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), textureImage); 
	}

}
