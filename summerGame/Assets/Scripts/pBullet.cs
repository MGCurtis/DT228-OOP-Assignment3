using UnityEngine;
using System.Collections;

public class pBullet : Bullet {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "Enemy")
			Destroy(gameObject);
		
	}
}
