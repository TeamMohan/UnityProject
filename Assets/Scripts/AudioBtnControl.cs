using UnityEngine;
using System.Collections;

public class AudioBtnControl : MonoBehaviour {

	public GameObject audioControl;

	void OnMouseDown(){
		Instantiate (audioControl);
	}
}
