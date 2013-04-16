using UnityEngine;
using System.Collections;

public class PauseGUI : MonoBehaviour {
	public Texture2D bg;
	public Texture2D keyboard;
	public GUIStyle pauseStyle;
	public GUIStyle Title;
	
	void OnGUI() {
		GUIStyle backgroundStyle = new GUIStyle();
		backgroundStyle.normal.background = bg;
		GUI.Label ( new Rect( 0, 0, Screen.width, Screen.height), "", backgroundStyle); 
		
		GUI.Label (new Rect( Screen.width/2-200, 30, 400, 70),     "PAUSED", Title); 
		GUI.Label(new Rect(300, 200, 1000, 500), keyboard);
		GUI.Label (new Rect( Screen.width-500, Screen.height - 360, 400, 70),     "Movement:  WASD or Arrow Keys", pauseStyle); 
		GUI.Label (new Rect( Screen.width-500, Screen.height - 400, 400, 70),     "Ability:  Shift", pauseStyle); 
		GUI.Label (new Rect( Screen.width-500, Screen.height - 450, 400, 70),     "Jump:  Spacebar", pauseStyle); 
		GUI.Label (new Rect( Screen.width-500, Screen.height - 500, 400, 70),     "Age:  Q", pauseStyle); 
		GUI.Label (new Rect( Screen.width-500, Screen.height - 550, 400, 70),     "Rebirth:  R", pauseStyle); 
		GUI.Label (new Rect( Screen.width-500, Screen.height - 600, 400, 70),     "Pause/Unpause:  P", pauseStyle); 
		
		if (Input.GetKeyDown ("p")) {
			
			
		}
	}
}
