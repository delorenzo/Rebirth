using UnityEngine;
using System.Collections;

public class StartMenuGUI : MonoBehaviour {
	public Texture2D bg; 
	public Texture2D text;
	bool isLoading;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		GUIStyle backgroundStyle = new GUIStyle();
		backgroundStyle.normal.background = bg;
		GUI.Label ( new Rect( (float)((Screen.width - (Screen.height * 2)) * 0.75), 0, Screen.height * 2, Screen.height), "", backgroundStyle); 

		GUI.Label(new Rect( (Screen.width/2)-197, 50, 400, 100), text);
		if (GUI.Button( new Rect( (Screen.width/2)-70, Screen.height - 360, 140, 70), "Level 1")) {
			isLoading = true;
			Application.LoadLevel("LVL1_MAIN");  
		}
		
		if (GUI.Button( new Rect( (Screen.width/2)-70, Screen.height - 260, 140, 70), "Level 2")) {
			isLoading = true;
			Application.LoadLevel("LVL2_MAIN");  
		}
		
		if (GUI.Button( new Rect( (Screen.width/2)-70, Screen.height - 160, 140, 70), "Level 3")) {
			isLoading = true;
			Application.LoadLevel("LVL3_MAIN");  
		}
		/*
		bool isWebPlayer = (Application.platform == RuntimePlatform.OSXWebPlayer ||    Application.platform == RuntimePlatform.WindowsWebPlayer); 
		if (!isWebPlayer) {  
			if (GUI.Button(new Rect( (Screen.width/2)-70, Screen.height - 80, 140, 70), "Quit")) {
				Application.Quit(); 
			}
		}
		*/
		if (isLoading)  {
			GUI.Label (new Rect( (Screen.width/2)-110, (Screen.height / 2) - 60, 400, 70),     "Loading..."); 
		}

	}
}