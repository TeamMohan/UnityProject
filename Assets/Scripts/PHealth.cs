using UnityEngine;
using System.Collections;

public class PHealth : MonoBehaviour {
	public static float health = 100;
	public static float maxHealth = 100;
	public static bool isAlive = true;
	public GameObject enemy;

	public Texture hback,hframe,hfront;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(health <= 0)
		{
			Destroy(gameObject);
		}
	
	
	}



	void OnGUI()
	{
		Rect rect = new Rect(10,10,200,20);
		Rect rect2 = new Rect(10,10,200 * health / maxHealth,20);
		GUI.DrawTexture(rect,hback);
		
		GUI.DrawTexture(rect2,hfront);
		GUI.DrawTexture(rect,hframe);
	}
}
