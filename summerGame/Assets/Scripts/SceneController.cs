using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public float enemyYLim = 35f;
	public float enemyXLim = 20f;
	public float pUYLim = 30f;
	public float pUXLim = 15f;
	public int enemyCount = 300;
	public int pUCount = 300;

	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		enemyCount --;
		pUCount --;

		SpawnEnemy();

	}

	void SpawnEnemy () {
		if(enemyCount <= 0)
		{
			enemyCount = 300;
			Instantiate(enemy, new Vector3(Random.Range(-enemyYLim,enemyYLim), 0,
			                               Random.Range(-enemyXLim, enemyXLim)), Quaternion.identity);
		}

	}
}
