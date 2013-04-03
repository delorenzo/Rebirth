using UnityEngine;
using System.Collections;
public class Age : MonoBehaviour{
	

	/// The game object to affect. If none, the trigger work on this game object
	public GameObject[] Player = new GameObject[5];
	public GameObject obj;
	float timer;
	


	public void DoAge () {
		int nextindex;
		for (var i = 0; i < 5; i++) {
			if (Player[i].activeSelf) { 
				obj = Player[i];
				obj.SetActive(false);
				nextindex = i % 4 + 1;
				Player[nextindex].transform.position = Player[i].transform.position;
				Player[nextindex].SetActive(true);
				break;
			}
		}
	}
	
	void Start() {
		timer = 0; 	
	}

	void Update() {
		timer += Time.deltaTime;
		if (timer > 20) { 
			timer = 0;
			DoAge ();
		}
		else {
			if (Input.GetKeyDown ("q")) {
				timer = 0;
				DoAge ();
			}
		}
		if (Input.GetKeyDown ("r")) { 
			timer = 0; 
		}
	}

}
