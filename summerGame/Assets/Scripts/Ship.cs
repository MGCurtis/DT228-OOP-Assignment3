using UnityEngine;
using System.Collections;

public abstract class Ship : MonoBehaviour {

	public float moveSpeed = 20f;
	public float turnSpeed = 200f;
	public int health = 5;
	public Object Bullet;
	public Transform shipNose;
	protected float fDelay;

	protected void Die () 
	{
		Destroy(gameObject);
	}

	protected void Fire () {
		if(fDelay <= 0)
		{
			fDelay = 30f;
			Instantiate(Bullet, shipNose.position, shipNose.rotation);
		}
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
