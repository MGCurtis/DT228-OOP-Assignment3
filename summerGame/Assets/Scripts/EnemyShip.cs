using UnityEngine;
using System.Collections;

public class EnemyShip : Ship {

	protected Transform target;
	public int health = 3;

	
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
		fDelay = 90f;
	}

	protected override void Fire ()
	{
		base.Fire();
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(target);

		transform.Translate(new Vector3(0,0,0.05f));

		fDelay --;

		int n = Random.Range(1, 26);
		if(n < 2 && fDelay <= 0)
		{
			fDelay = 90f;
			Fire ();
		}

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
