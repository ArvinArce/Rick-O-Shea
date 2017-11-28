using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour {


	public Vector3[] spawnLoc;
	public GameObject[] enemies;
	public int totalEnemies;
	public float spawnWait;
	public float startWait;


	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	void Update () {
		
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		int enemiesSpawned = 0;
		int spawnLocation = 0;
		while (enemiesSpawned < totalEnemies) {
			Instantiate (enemies [enemiesSpawned % enemies.Length], spawnLoc[spawnLocation % spawnLoc.Length], Quaternion.identity);
			spawnLocation++;
			enemiesSpawned++;
			yield return new WaitForSeconds (spawnWait);
		}

	}
}
