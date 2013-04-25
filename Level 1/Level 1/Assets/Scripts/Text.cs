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
	int start = 1;
	public int on = 0;
	public Text2 text;
	public Text2 text2;
	public Text2 text3;
	
	void OnTriggerEnter(){
		if(text.on != 1 && text2.on != 1 && text3.on != 1){
			start = 1;
			on = 1;
		}
		else{
			text.Off(); 
			text2.Off ();
			text3.Off ();
			start = 1;
			on = 1;
		}
	}
	
	void OnGUI(){
		if(start == 1){
			Timer ();
			
			if(starttext < words.Length && starttext > -1){
				got =  GUI.TextArea(new Rect(width/3, height- height/4, 400, 100), words[starttext], 200);
			}
		}

	}
	
	void Update(){
		if(Input.GetKeyDown ("f")){
			if(starttext != 9){
				starttext +=1;
				timer = 0;
			}
		}
		
		if(starttext > words.Length){
			start = 0;
			on = 0;
			starttext = 0;
		}
		OnGUI ();
	}
	
	void Timer(){
		timer += Time.deltaTime;
		if(timer > 15 && starttext != 0 && starttext != -1){
			starttext++;
			timer = 0;
		}
		
		if(starttext > words.Length){
			start = 0;
			on = 0;
			starttext = 0;
		}
		
	}
	
	public void Off(){
		start = 0;
		on = 0;
		starttext= 0;
		OnGUI();
	}
	
	
}