using UnityEngine;
using System.Collections;

public class EnemyShip : Ship {

	protected Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);

	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "pBullet")
			Destroy(gameObject);
			//health --;
		if(trig.gameObject.tag == "Player")
			Destroy(gameObject);
			//health --;
	}
}
