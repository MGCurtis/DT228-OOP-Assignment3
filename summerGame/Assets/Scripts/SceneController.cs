using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public float enemyYLim = 35f;
	public float enemyXLim = 20f;
	public float pUYLim = 30f;
	public float pUXLim = 15f;
	public int enemyCount = 0;
	public int pUCount = 720;


	public GameObject enemy;

	public GameObject health;
	public GameObject gun;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		enemyCount --;
		pUCount --;

		SpawnEnemy();
		SpawnPowerUp();
	}

	void SpawnEnemy () {
		if(enemyCount <= 0)
		{
			enemyCount = 300;
			Instantiate(enemy, new Vector3(Random.Range(-enemyYLim,enemyYLim), 0,
			                               Random.Range(-enemyXLim, enemyXLim)), Quaternion.identity);
		}

	}

	void SpawnPowerUp () {
		if(pUCount <= 0)
		{
			int pUType = Random.Range(1,3);
			pUCount = 720;

			if(pUType == 1)
				Instantiate(gun, new Vector3(Random.Range(-pUYLim,pUYLim), 0,
				                               Random.Range(-pUXLim, pUXLim)), Quaternion.identity);
			else if(pUType == 2)
				Instantiate(health, new Vector3(Random.Range(-pUYLim,pUYLim), 0,
				                               Random.Range(-pUXLim, pUXLim)), Quaternion.identity);

		}
	}
}
