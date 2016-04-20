using UnityEngine;
using System.Collections;

public abstract class Ship : MonoBehaviour {

	public float moveSpeed = 20f;
	public float turnSpeed = 400f;

	public Object Bullet;
	public Transform shipNose;
	protected float fDelay;



	protected void Die () 
	{
		Destroy(gameObject);
	}

	protected virtual void Fire () {
		Instantiate(Bullet, shipNose.position, shipNose.rotation);
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
