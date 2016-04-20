using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width*0.89f, Screen.height*0.89f, Screen.width*0.1f, Screen.height*0.1f), "Play"))
			Application.LoadLevel("game");
	}
}
