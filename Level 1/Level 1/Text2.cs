using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
	public string [] words = new string[6];
	string got;
	int width = Screen.width;
	int height = Screen.height;
	int boxtext;
	float timer = 0;
	int starttext = 0;
	int begin = 0;
	int prevtext = 0;
	int start = 0;
	
	void OnTriggerEnter(){
		start = 1;
	}
	
	void OnGUI(){
		if(start == 1){
			if(begin == 0){
				SetUp ();
			}
			Timer ();
			
			if(starttext < words.Length && starttext > -1){
				got =  GUI.TextArea(new Rect(width/3, height- height/4, 400, 100), words[starttext], 200);
			}
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
		
		if(starttext > 5){
			start = 0;
			starttext = 0;
		}
	}
	
	void Timer(){
		timer += Time.deltaTime;
		if(timer > 15 && starttext != 0 && starttext != -1){
			starttext++;
			timer = 0;
		}
		
		if(starttext > 5){
			start = 0;
			starttext = 0;
		}
		
	}
	
	void SetUp(){
		words[0] = "The small chick is small and cute. It can get through small obstacles. Use this form to cross the bridge.";
		begin++;
	}
	
	
}