using UnityEngine;
using System.Collections;

public class PlayerShip : Ship {

	public float wrapWidth = 35f;
	public float wrapHeight = 20f;

	private int gunTimer = 0;
	private bool gunPU = false;

	public Shader shader1;
	public Shader shader2;
	public Renderer rend;

	
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

	protected override void Fire () {
		base.Fire();
	}

	// Use this for initialization
	void Start () {
		rend = GetComponentInChildren<Renderer>();
		shader1 = Shader.Find("Diffuse");
		shader2 = Shader.Find("Self-Illumin/Diffuse");
	}
	
	// Update is called once per frame
	void Update () {

		Movement();
		transform.Translate(0,0,0);

		fDelay --;

		if(Input.GetKey(KeyCode.Space) && fDelay <= 0)
		{
			if(gunPU == true)
				fDelay = 5;
			else
				fDelay = 30;

			Fire();
		}

		if(gunPU == true && rend.material.shader == shader1)
			rend.material.shader = shader2;

		if(gunPU == false && rend.material.shader == shader2)
			rend.material.shader = shader1;

		if(gunTimer > 0)
		{
			gunTimer --;
			gunPU = true;
		}

		if(gunTimer <= 0)
			gunPU = false;

		if(health == 0)
			Die();

		
		if(transform.position.x > wrapWidth)
			transform.position = new Vector3(-wrapWidth, transform.position.y, transform.position.z);
		if(transform.position.x < -wrapWidth)
			transform.position = new Vector3(wrapWidth, transform.position.y, transform.position.z);
		Debug.Log(fDelay);
		if(transform.position.z > wrapHeight)
			transform.position = new Vector3(transform.position.x ,transform.position.y, (wrapHeight * -1));
		if(transform.position.z < -wrapHeight)
			transform.position = new Vector3(transform.position.x ,transform.position.y, wrapHeight);

	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "eBullet")
			health --;
			
		if(trig.gameObject.tag == "Enemy")
			health --;

		if(trig.gameObject.tag == "health")
			health ++;

		if(trig.gameObject.tag == "gun")
			gunTimer = 300;

	}
}
