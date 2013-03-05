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
		if (currentObject != null)  {
			old = currentObject;
			Destroy(currentObject);
			currentObject = (GameObject)Instantiate(objects[index], old.transform.position, old.transform.rotation);
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