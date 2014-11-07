using UnityEngine;
using System.Collections;

public class ECastleHealth : MonoBehaviour {
	
	public static float health = 100;
	public float maxHealth = 100;
	public GameObject player;
	public float distance;
	
	public Texture hback,hframe,hfront;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position,GameObject.FindGameObjectWithTag("EnemyCastle").transform.position);

		if(distance < 15 && Input.GetMouseButtonDown(0))
		{
			health -=5;
		}
		if(health <=0)
		{
			health =0;
		}
		if(health == 0)
		{
			Destroy(gameObject);
		}

	}
	void OnGUI()
	{
		Rect rect = new Rect(Screen.width - 250,10,200,20);
		Rect rect2 = new Rect(Screen.width - 250,10,200 * health / maxHealth,20);
		Rect rect3 = new Rect(Screen.width - 225,10,200,20);
		
		if(distance <15)
		{
			GUI.Label(rect,"EnemyHealth");
			GUI.DrawTexture(rect,hback);
			
			GUI.DrawTexture(rect2,hfront);
			GUI.DrawTexture(rect,hframe);
			GUI.contentColor = Color.black;
			GUI.Label(rect3,"Enemy Castle Health");

		}
	}
	
	void OnMouseDown()
	{
		Vector3 dir = (player.transform.position - transform.position).normalized;
		float direction = Vector3.Dot(dir,transform.forward);

		if(distance < 20.5f)
		{
			if(direction > 0)
			{
				health -= 10;
			}
		
		}
		
	}
}
