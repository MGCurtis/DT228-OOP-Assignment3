using UnityEngine;
using System.Collections;

public abstract class Bullet : MonoBehaviour {

	protected float moveSpeed = 50f;
	public float timer = 75f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		transform.Translate(new Vector3(0,0,1) * moveSpeed * Time.deltaTime);
		timer --;
		if(timer <= 0)
			Destroy(gameObject);
	}
}
