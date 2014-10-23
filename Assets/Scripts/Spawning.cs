using UnityEngine;
using System.Collections.Generic;


public class Spawning : MonoBehaviour {

	public GameObject enemy;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject spawn;
	public List<GameObject> enemyList = new List<GameObject>();

	public float timmer;
	public int enemyCount;


	// Use this for initialization
	void Start () {
		enemyList.Add(enemy);
		enemyList.Add(enemy2);
		enemyList.Add(enemy3);
	
	}
	
	// Update is called once per frame
	void Update () {

     	if (enemyCount < 10) 
		{
			timmer += Time.deltaTime;
			if (timmer > 2) 
			{
			 Instantiate (enemyList[(int)Random.Range(0,enemyList.Count)], new Vector3 (spawn.transform.position.x, spawn.transform.position.y, spawn.transform.position.z), Quaternion.identity);
			 enemyCount += 1;
			 timmer = 0;
			}
		}
	}
}
	