using UnityEngine;

public class Age : MonoBehavior{
	int timer;

	/// The action(s) to accomplish
	public Mode age = Mode.Activate;

	/// The game object to affect. If none, the trigger work on this game object
	public GameObject[] objects = new GameObject[5];
	public int index;
	public GameObject current, old;
	void DoAge () {
		index = Mathf.Repeat(index, objects.length);
		if (index == 4) {
			//animation for elder -> egg	
		}
		if (currentObject != null)  {
			old = currentObject;
			Destroy(currentObject);
			currentObject = Instantiate(objects[index], old.transform.position, old.transform.rotation);
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