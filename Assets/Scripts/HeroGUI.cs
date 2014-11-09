using UnityEngine;
using System.Collections;

public class HeroGUI : MonoBehaviour {
	
	public Texture border, red, green;

	public float maxHealth;
	private float health;
	public bool hit;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		Rect hPos = new Rect (10f, 10f, 200f, 50f);
		GUI.DrawTexture (hPos, red);
		GUI.DrawTexture (hPos, green);
		GUI.DrawTexture (hPos, border);
	}
}
