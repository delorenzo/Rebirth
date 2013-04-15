using UnityEngine;
using System.Collections;

public class StartMenuGUI : MonoBehaviour {
	public Texture2D bg; 
	public Texture2D[] text;
	bool isLoading;
	int i;
	
	// Use this for initialization
	void Start () {
		i = 0;
		StartCoroutine(updateFrame());
	}
	
	IEnumerator updateFrame() {
		while (true) {
			i++;
			if (i > 4) { i = 0; }
			yield return new WaitForSeconds(0.1f);
		}
	}

	
	void OnGUI () {
		GUIStyle backgroundStyle = new GUIStyle();
		backgroundStyle.normal.background = bg;
		GUI.Label ( new Rect( 0, 0, Screen.width, Screen.height), "", backgroundStyle); 
		GUI.contentColor = Color.white;
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
		
		GUI.Label(new Rect( (Screen.width/2)-350, (Screen.height / 2) -400, Screen.width/3, Screen.height/3), text[i]);
		

	}
}