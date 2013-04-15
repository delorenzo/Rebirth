using UnityEngine;
using System.Collections;

public class LevelGUI : MonoBehaviour {
	public Texture2D[] forms;
	public Texture2D[] inventory;
	
	public Texture2D blank;
	public Texture2D keyTex;
	public Inventory inv;
	public GameObject[] player;
	public Texture2D [] active;
	public Texture2D [] inactive;
	
	
	void Start() {
		inventory = new Texture2D[5];
		for (int i = 0; i < 5; i++) {
			inventory[i] = blank;	
		}
		for (int i = 0; i < 4; i++) {
			forms[i] = inactive[i];
		}
	}
	
	void OnGUI() {
		if (inv.hasItem ("Key")) {
			inventory[0] = keyTex;	
		}
		
		for (int i = 0; i < 4; i++) {
			if (player[i].activeSelf) { 
				forms[i] = active[i];
			}
			else {
				forms[i] = inactive[i];
			}
		}
		
		GUI.Label(new Rect( 0, Screen.height-150, Screen.width/8, Screen.height/8), forms[0]);
		GUI.Label(new Rect( 120, Screen.height-150, Screen.width/8, Screen.height/8), forms[1]);
		GUI.Label(new Rect( 240, Screen.height-150, Screen.width/8, Screen.height/8), forms[2]);
		GUI.Label(new Rect( 360, Screen.height-150, Screen.width/8, Screen.height/8), forms[3]);
		
		GUI.Label(new Rect( Screen.width-150, Screen.height-150, Screen.width/8, Screen.height/8), inventory[0]);
	}
	
}
