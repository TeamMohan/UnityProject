using UnityEngine;
using System.Collections;

public class MenuBtnControl : MonoBehaviour {

	public string scene;
	public bool exit;
	
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		if (exit == true){
			Application.Quit();
			print("Closing Game");
		}
		else{
			Application.LoadLevel(scene);
		}
	}
}
