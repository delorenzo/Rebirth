using UnityEngine;
using System.Collections;

public class LevelGUI : MonoBehaviour {
	
	//HUD stuff
	public Texture2D[] forms;
	public Texture2D[] inventory;
	public Texture2D blank;
	public Texture2D keyTex;
	public Inventory inv;
	public GameObject[] player;
	public Texture2D [] activeforms;
	public Texture2D [] inactiveforms;
	
	//pause stuff
	public Texture2D keyboard;
	public GUIStyle pauseStyle;
	public GUIStyle Title;
	bool pause;
	
	void Start() {
		pause = false;
		inventory = new Texture2D[5];
		for (int i = 0; i < 5; i++) {
			inventory[i] = blank;	
		}
		for (int i = 0; i < 4; i++) {
			forms[i] = inactiveforms[i];
		}
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.P)) {
			Debug.Log ("Pause pressed");
			if (pause) { 
				pause = false;
				Time.timeScale = 1;
			}
			else { 
				pause = true;
				Time.timeScale = 0;
			}
		}
	}
	
	void OnGUI() {
		if (pause) {
			GUI.Label (new Rect( Screen.width/2-200, 30, 400, 70),     "PAUSED", Title); 
			GUI.Label(new Rect(300, 200, 1000, 500), keyboard);
			GUI.Label (new Rect( Screen.width-500, Screen.height - 360, 400, 70),     "Movement:  WASD or Arrow Keys", pauseStyle); 
			GUI.Label (new Rect( Screen.width-500, Screen.height - 400, 400, 70),     "Ability:  Shift", pauseStyle); 
			GUI.Label (new Rect( Screen.width-500, Screen.height - 450, 400, 70),     "Jump:  Spacebar", pauseStyle); 
			GUI.Label (new Rect( Screen.width-500, Screen.height - 500, 400, 70),     "Age:  Q", pauseStyle); 
			GUI.Label (new Rect( Screen.width-500, Screen.height - 550, 400, 70),     "Rebirth:  R", pauseStyle); 
			GUI.Label (new Rect( Screen.width-500, Screen.height - 600, 400, 70),     "Pause/Unpause:  P", pauseStyle); 
		}
		else {
			if (inv.hasItem ("Key")) {
				inventory[0] = keyTex;	
			}
			else {
				inventory[0] = blank;	
			}
		
			for (int i = 0; i < 4; i++) {
				if (player[i].activeSelf) { 
					forms[i] = activeforms[i];
				}
				else {
					forms[i] = inactiveforms[i];
				}
			}
		
			GUI.Label(new Rect( 0, Screen.height-150, Screen.width/8, Screen.height/8), forms[0]);
			GUI.Label(new Rect( 120, Screen.height-150, Screen.width/8, Screen.height/8), forms[1]);
			GUI.Label(new Rect( 240, Screen.height-150, Screen.width/8, Screen.height/8), forms[2]);
			GUI.Label(new Rect( 360, Screen.height-150, Screen.width/8, Screen.height/8), forms[3]);
		
			GUI.Label(new Rect( Screen.width-150, Screen.height-150, Screen.width/8, Screen.height/8), inventory[0]);
		}
	}
	
}
