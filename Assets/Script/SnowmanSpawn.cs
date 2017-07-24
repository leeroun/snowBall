using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanSpawn : MonoBehaviour {
	public static SnowmanSpawn instance;
	public Transform spawnPoint;
	public int waveIndex=0;
	private float countdown= 2f;
	public float timeBetweenWaves= 5f;
	public int round=1;
	public int SnowmanKill= 0;
	// Use this for initialization
	void Start() {
		instance = this;
	}

	void Update() {
		if (countdown <= 0f) {
			StartCoroutine (SpawnWave ());
			countdown = timeBetweenWaves;
			round++;
		}
		countdown -= Time.deltaTime;
	}

	IEnumerator SpawnWave() {
		waveIndex = Random.Range (1, 4);

		for (int i = 0; i < waveIndex; i++) {
			SpawnEnemy ();
			yield return new WaitForSeconds (10f);
		}
	}

	void SpawnEnemy() {
		GameObject Obj_Snowman = ObjectPool_Snowman.instance.GetPooledObject_Snowman ();
		Obj_Snowman.GetComponent<Snowman> ().Hp =Obj_Snowman.GetComponent<Snowman> ().divideHP =Random.Range (3, 6);
		Obj_Snowman.transform.position = spawnPoint.position;
		Obj_Snowman.SetActive (true);
	}
}
