using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {

		GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
		myBoxStyle.fontSize = 40;

		GUI.Box(new Rect(Screen.width*0.25f, Screen.height*0.25f,
		                 Screen.width*0.5f, Screen.height*0.25f), "Game Over", myBoxStyle);

		if(GUI.Button (new Rect(Screen.width*0.25f, Screen.height*0.5f,
		                        Screen.width*0.2f, Screen.height*0.1f), "Play Again"))
			Application.LoadLevel("game");
		if(GUI.Button (new Rect(Screen.width*0.55f, Screen.height*0.5f,
		                        Screen.width*0.2f, Screen.height*0.1f), "Exit"))
			Application.Quit();
	}

}
