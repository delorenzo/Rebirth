using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
	string [] words = new string[12];
	string got;
	int width = Screen.width;
	int height = Screen.height;
	int boxtext;
	float timer = 0;
	int starttext = 0;
	int begin = 0;
	int prevtext = 0;
	
	void OnGUI(){
		if(begin == 0){
			SetUp ();
		}
		Timer ();
		
		if(starttext < words.Length && starttext > -1){
			got =  GUI.TextArea(new Rect(width/3, height- height/4, 400, 75), words[starttext], 200);
		}

	}
	
	void Update(){
		if(Input.GetKeyDown ("f")){
			if(starttext != 9 && starttext != 6 && starttext != 8){
				starttext +=1;
				timer = 0;
				OnGUI ();
			}
		}
		if(Input.GetKeyDown ("q") && starttext == 3){
			starttext +=1;
			timer = 0;
			OnGUI ();
		}
			
		if(Input.GetKeyDown ("r") && starttext == 5){
			starttext += 1;
			timer = 0;
			OnGUI ();
		}
	}
	
	void Timer(){
		timer += Time.deltaTime;
		if(timer > 15 && starttext != 0 && starttext != 9 && starttext != 6 && starttext != 8 && starttext != -1){
			starttext++;
			timer = 0;
		}
		else if((starttext == 6 || starttext == 9 || starttext == 8) && timer > 15){
			prevtext = starttext;
			starttext = -1;
			timer = 0;
		}
		else if(prevtext == 9 && timer > 45){
			starttext = 10;
			timer = 0;
		}
		else if(prevtext == 6 && timer > 15){
			starttext = 7;
			timer = 0;
		}
		else if (prevtext == 8 && timer > 30){
			starttext = 9;
			timer = 0;
		}
		
	}
	
	void SetUp(){
		words[0] = "Find the Key. Defeat the fox. Save the tree. Save the world.\n\n\nPress F to continue.";
		words[1] = "Use W, A, S, and D to move. Press space to jump. Turn the camera with the mouse.";
		words[2] = "As a phoenix you have many ages and forms. Use these to get to the fox.";
		words[3] = "Press Q to change forms. The boxes on the side show which form you are in.";
		words[4] = "Each form has a special ability represented by the side box.";
		words[5] = "Press R to rebirth back to the small chick.";
		words[6] = "The small chick is fast and fun. It can get through small obstacles. Use this form to cross the bridge.";
		words[7] = "Water is your natural enemy. If you try to walk through it you will die.";
		words[8] = "The adolescent phoenix can burst really fast. Hold Shift and move to run fast. Use this form to burst through the waterfall without dying.";
		words[9] = "The adult form of the phoenix can fly. Press Shift up to three times to fly across the islands and get the key.";
		words[10] = "The elder phoenix can breathe fire to destroy things. Press shift to destroy the bushes.";
		begin++;
	}
	
	
}