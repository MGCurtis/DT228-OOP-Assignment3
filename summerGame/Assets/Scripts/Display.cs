using UnityEngine;
using System.Collections;

public class Display : MonoBehaviour {

	public static int healthCount;
	public static int score;

	// Use this for initialization
	void Start () {
		healthCount = PlayerShip.health;
	}
	
	// Update is called once per frame
	void Update () {
		healthCount = PlayerShip.health;
	}

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, Screen.width*0.15f, Screen.height*0.1f), "Health: " + healthCount.ToString());
		GUI.Box(new Rect(0, Screen.height*0.1f, Screen.width*0.15f, Screen.height*0.1f), "Score: " + score.ToString());
	}
}
