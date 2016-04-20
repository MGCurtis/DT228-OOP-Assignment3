using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {

	private int temp = 1080;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		temp--;
		if(temp <= 0)
			Destroy(gameObject);
	}

	void OnTriggerEnter (Collider trig) {
		if(trig.gameObject.tag == "Player")
			Destroy(gameObject);
	}
}
