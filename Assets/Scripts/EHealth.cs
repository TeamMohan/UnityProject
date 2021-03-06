﻿using UnityEngine;
using System.Collections;

public class EHealth : MonoBehaviour {

	public float health = 100;
	public float maxHealth = 100;
	public GameObject player;

	public float attackTimer;
	public float cooldown;
	float distance;


	public Texture hback,hframe,hfront;

	// Use this for initialization
	void Start () {
	
		attackTimer = 0;
		cooldown = 2.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		distance = Vector3.Distance(player.transform.position, transform.position);
		if(attackTimer > 0)
			attackTimer -= Time.deltaTime;
		
		if(attackTimer < 0)
			attackTimer = 0;
		
		if(attackTimer == 0)
		{
			Attack();
			attackTimer = cooldown;
		}
		if(health <=0)
		{
			Destroy(gameObject);
		}



	}
	void Attack()
	{
		if(player != null)
		{
			float distance = Vector3.Distance(player.transform.position, transform.position);
			float distance2 = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position,GameObject.FindGameObjectWithTag("AllyCastle").transform.position);

			if(distance < 2.5f)
			{
				PHealth.health -= 2;
				
			}
			if(distance2 < 5)
			{
				ACastleHealth.health -=10;
			}
		}
	}

	void OnGUI()
	{

			
			float hbarwidth = 100;
			float hbarheight = 12;
		//print (distance);
			Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);// gets screen position.
			screenPosition.y = Screen.height - (screenPosition.y + 1);// inverts y
			Rect rect = new Rect(screenPosition.x - 50,
			                     screenPosition.y - 50, hbarwidth,hbarheight);// makes a rect centered at the player ( 100x24 )
			Rect rect2 = new Rect(screenPosition.x - 50,
			                     screenPosition.y - 50, hbarwidth * health / maxHealth, hbarheight);// makes a rect centered at the player ( 100x24 )

			if(distance < 15)
			{
				GUI.DrawTexture(rect,hback);

				GUI.DrawTexture(rect2,hfront);
				GUI.DrawTexture(rect,hframe);
			}

	}

	void OnMouseDown()
	{
		float distance = Vector3.Distance(player.transform.position, transform.position);
		if(distance < 2.5f)
		{
			health -= 10;
			
		}
		
	}



}