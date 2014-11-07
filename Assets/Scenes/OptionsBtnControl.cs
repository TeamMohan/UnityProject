using UnityEngine;
using System.Collections;

public class OptionsBtnControl : MonoBehaviour {

	public Camera cam;
	public GameObject title;

	private static bool enterOptions, move;
	private Vector3 camPos1, camPos2;
	private Vector3 titlePos1, titlePos2;

	void Start () {
		camPos1 = cam.transform.position;
		camPos2 = new Vector3 (camPos1.x + 20, camPos1.y, camPos1.z);
		titlePos1 = title.transform.position;
		titlePos2 = new Vector3 (titlePos1.x + 20, titlePos1.y, titlePos2.z);

		enterOptions = false;
		move = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (move){
			if (enterOptions){
				cam.transform.position = Vector3.MoveTowards(cam.transform.position, camPos2, Time.deltaTime * 10);
				title.transform.position = Vector3.MoveTowards(title.transform.position, titlePos2, Time.deltaTime * 10);
				if (cam.transform.position == camPos2)
					move = false;
			}
			else{
				cam.transform.position = Vector3.MoveTowards(cam.transform.position, camPos1, Time.deltaTime * 10);
				title.transform.position = Vector3.MoveTowards(title.transform.position, titlePos1, Time.deltaTime * 10);
				if (cam.transform.position == camPos1)
					move = false;
			}
		}
	}
	void OnMouseDown(){
		if (enterOptions){
			enterOptions = false;
			move = true;
		}
		else{
			enterOptions = true;
			move = true;
		}
	}
}
