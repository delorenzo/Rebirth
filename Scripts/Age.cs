using UnityEngine;
using System.Collections;
public class Age : MonoBehaviour{
	float timer;

	

	/// The game object to affect. If none, the trigger work on this game object
	public GameObject[] objects = new GameObject[5];
	public int index;
	public GameObject currentObject, old;
	public void DoAge () {
		
		index = (int)Mathf.Repeat((float)index, objects.Length);
		if (index == 4) {
			//animation for elder -> egg	
		}
		for (int i = 0; i < 5; i++) {
			if (i == index) {
				GameObject.Find("3rd Person Controller " + i).renderer.enabled = true;
				GameObject.Find("3rd Person Controller " + i).transform.position = this.transform.position;
				GameObject.Find("3rd Person Controller " + i).transform.rotation = this.transform.rotation;
			}
			else {
				GameObject.Find("3rd Person Controller " + i).renderer.enabled = false;
				
			}
			
		}
	}
	
	void Start() {
		timer = 0; 	
	}

	void Update() {
		timer += Time.deltaTime;
		if (timer > 10) { DoAge ();}
	}
}