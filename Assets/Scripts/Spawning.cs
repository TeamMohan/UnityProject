using UnityEngine;
using System.Collections.Generic;


public class Spawning : MonoBehaviour {

	public GameObject enemy;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject spawn;
	public GameObject spawnPointOne;
	public GameObject spawnPointTwo;
	public GameObject spawnPointThree;
	public List<GameObject> enemyList = new List<GameObject>();
	public List<GameObject> startSpawn = new List<GameObject> ();
	public GameObject temp;
	public float timmer;
	public int enemyCount;
	public int speed;
	public int randomSelection;




	// Use this for initialization
	void Start () {
		enemyList.Add(enemy);
		enemyList.Add(enemy2);
		enemyList.Add(enemy3);
		startSpawn.Add(spawnPointOne);
		startSpawn.Add(spawnPointTwo);
		startSpawn.Add(spawnPointThree);

		speed = 10;	
	}
	
	// Update is called once per frame
	void Update () {

     	if (enemyCount < 100) 
		{
			timmer += Time.deltaTime;
			if (timmer > 2) 
			{
			randomSelection = Random.Range(0,startSpawn.Count);
			
				temp = Instantiate(enemyList[(int)Random.Range(0,enemyList.Count)], new Vector3 (spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z), Quaternion.identity) as GameObject;




	 enemyCount += 1;
			 timmer = 0;
			}
		}
	}
}
	