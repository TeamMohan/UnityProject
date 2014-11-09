using UnityEngine;
using System.Collections;

public class AudioControl : MonoBehaviour {

	public GUISkin optionsStyle;
	public Texture border;
	private float volSFX, volMusic;
	void Start () {
		volSFX = 1f;
		volMusic = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		Rect optionMenu = new Rect (Screen.width / 2 - 200, Screen.height / 2 - 100, 400, 400);
		Rect bg = new Rect (0, 0, 400, 400);
		Rect titlePos = new Rect (20, 15, 200, 50);
		Rect slidTitle1 = new Rect (20, 50, 60, 30);
		Rect slid1 = new Rect (80, 60, 200, 30);
		Rect slidTitle2 = new Rect (20, 80, 60, 30);
		Rect slid2 = new Rect (80, 90, 200, 30);
		Rect close = new Rect (360, 20, 20, 20);

		GUI.BeginGroup (optionMenu);
		GUI.skin = optionsStyle;
		GUI.DrawTexture (bg, border);
		GUI.Label (titlePos, "Audio Settings");
		GUI.Label (slidTitle1, "Music");
		volMusic = GUI.HorizontalSlider (slid1, volMusic, 0.0f, 1.0f);
		GUI.Label (slidTitle2, "SFX");
		volSFX = GUI.HorizontalSlider (slid2, volSFX, 0.0f, 1.0f);
		if (GUI.Button (close, "X")){
			Destroy(this);
		}

		GUI.EndGroup ();
	}
}
