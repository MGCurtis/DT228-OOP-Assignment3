using UnityEngine;
using System.Collections;

public class PlayerShip : Ship {

	public float wrapWidth = 35f;
	public float wrapHeight = 15f;

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

		
		if(transform.position.x >= wrapWidth)
			transform.position = new Vector3(-wrapWidth, transform.position.y, transform.position.z);
		if(transform.position.x <= -wrapWidth)
			transform.position = new Vector3(wrapWidth, transform.position.y, transform.position.z);
		Debug.Log(transform.position.x);
		if(transform.position.y >= wrapHeight)
			transform.position = new Vector3(transform.position.x ,transform.position.y, wrapHeight);
		if(transform.position.y >= wrapHeight)
			transform.position = new Vector3(transform.position.x ,transform.position.y, wrapHeight);

	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "eBullet")
			health --;
			
		if(trig.gameObject.tag == "Enemy")
			health --;
	}
}
