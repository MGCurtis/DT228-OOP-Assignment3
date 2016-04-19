using UnityEngine;
using System.Collections;

public abstract class Ship : MonoBehaviour {

	public float moveSpeed = 20f;
	public float turnSpeed = 100f;
	public int health = 5;
	public Object pBullet;
	public Transform shipNose;
	public float fDelay;
	
	protected void Fire () {
		if(fDelay <= 0)
		{
			fDelay = 30f;
			Instantiate(pBullet, shipNose.position, shipNose.rotation);
		}
	}
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
