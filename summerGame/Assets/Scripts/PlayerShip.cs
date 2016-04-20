using UnityEngine;
using System.Collections;

public class PlayerShip : Ship {

	protected void Movement () {
		if(Input.GetKey(KeyCode.W))
			transform.Translate(new Vector3(0,0,1) * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.S))
			transform.Translate(new Vector3(0,0,-1) * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.A))
			transform.Rotate(new Vector3(0,-1,0) * turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.D))
			transform.Rotate(new Vector3(0,1,0) * turnSpeed * Time.deltaTime);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Movement();
		transform.Translate(0,0,0);

		fDelay --;

		if(Input.GetKey(KeyCode.Space))
			Fire();

		if(health == 0)
			Die();
	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "eBullet")
			health --;
			
		if(trig.gameObject.tag == "Enemy")
			health --;
	}
}
