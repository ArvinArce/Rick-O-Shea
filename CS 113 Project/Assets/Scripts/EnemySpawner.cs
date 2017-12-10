using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour {


	public Vector3[] spawnLoc;
	public GameObject[] enemies;
	public int totalEnemies;
	public float spawnWait;
	public float startWait;
	public GameController gameController;
	public GameObject spawnPortal;

	private bool spawnComplete = false;
	private bool doorOpened = false;

	void Start () {
		StartCoroutine (SpawnWaves ());
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController> ();
		} else {
			Debug.Log ("Cannot find 'GameController' object");
		}
		for (int i = 0; i < spawnLoc.Length; i++) {
			//Vector3 portalLoc = new Vector3 (spawnLoc [i].x, spawnLoc [i].y + 2, spawnLoc [i].z);
			Instantiate (spawnPortal, spawnLoc [i], Quaternion.identity);
		}
	}

	void Update () {
		if (spawnComplete && GameObject.FindGameObjectsWithTag ("Enemy").Length == 0 && !doorOpened) {
			GameObject[] spawnPortals = GameObject.FindGameObjectsWithTag ("SpawnPortal");
			for (int i = 0; i < spawnPortals.Length; i++) {
				Destroy (spawnPortals [i]);
			}
			gameController.RoomComplete ();
			doorOpened = true;
		}
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
		spawnComplete = true;

	}
}
