using UnityEngine;
using System.Collections;

public class EnemyShip : Ship {

	protected Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
		fDelay = 60f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);

		fDelay --;

		int n = Random.Range(1, 26);
		if(n < 2)
			Fire ();

		if(health == 0)
			Die();
	}

	void OnTriggerEnter (Collider trig)
	{
		if(trig.gameObject.tag == "pBullet")
			health --;

		if(trig.gameObject.tag == "Player")
			Die();
			//health --;
	}
}
