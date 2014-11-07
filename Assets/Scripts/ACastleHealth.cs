﻿using UnityEngine;
using System.Collections;

public class ACastleHealth : MonoBehaviour {

	public static float health = 100;
	public float maxHealth = 100;
	public GameObject player;
	float distance;

	public Texture hback,hframe,hfront;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position,GameObject.FindGameObjectWithTag("AllyCastle").transform.position);
	
	}
	void OnGUI()
	{

		Rect rect = new Rect(Screen.width - 250,10,200,20);
		Rect rect2 = new Rect(Screen.width - 250,10,200 * health / maxHealth,20);
		Rect rect3 = new Rect(Screen.width - 200,10,200,20);

		if(distance <15)
		{

			GUI.DrawTexture(rect,hback);
			
			GUI.DrawTexture(rect2,hfront);
			GUI.DrawTexture(rect,hframe);
			GUI.contentColor = Color.black;
			GUI.Label(rect3,"Ally Castle Health");

		}
	}


}
