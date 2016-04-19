using UnityEngine;
using System.Collections;

public class eBullet : Bullet {
	

	// Use this for initialization
	void Start () {
		timer = 150f;
		moveSpeed = 25f;
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "Player")
			Destroy(gameObject);
		
	}
}
