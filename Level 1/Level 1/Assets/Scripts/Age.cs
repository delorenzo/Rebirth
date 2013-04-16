using UnityEngine;
using System.Collections;
public class Age : MonoBehaviour{
	

	/// The game object to affect. If none, the trigger work on this game object
	public GameObject[] Player = new GameObject[5];
	public GameObject obj;
	//float timer;
	Vector3 temp = new Vector3(0f, 0.2f, 0f);
	
	//public CameraController camera;
	
	public GameObject GetPlayer(){
		for( int i = 0; i < 5; i++){
			if(Player[i].activeSelf){
				return Player[i];
			}
		}
		return Player[0];
	}
	
	public int GetNum(){
		for(int i = 0; i < 5; i++){
			if(Player[i].activeSelf){
				return i;
			}
		}
		return 0;
	}

	public void DoAge () {
		int nextindex;
		for (var i = 0; i < 5; i++) {
			if (Player[i].activeSelf) { 
				obj = Player[i];
				obj.SetActive(false);
				nextindex = i % 4 + 1;
				Player[nextindex].transform.position = Player[i].transform.position + temp;
				Player[nextindex].SetActive(true);
				break;
			}
		}
	}
	
	void Start() {
		//timer = 0; 	
		//camera = GetComponent<CameraController>();
	}

	void Update() {
		/*
		timer += Time.deltaTime;
		if (timer > 20) { 
			timer = 0;
			DoAge ();
		}
		*/

		if (Input.GetKeyDown ("q")) {
			//timer = 0;
			DoAge ();
		}
		
		else if (Input.GetKeyDown("r")) {
			//timer = 0; 
			
			for (var i = 0; i < 5; i++) {
				if (Player[i].activeSelf) { 
					obj = Player[i];
					obj.SetActive(false);
					Player[1].transform.position = Player[i].transform.position;
					Player[1].SetActive(true);
					break;
				}
			}
		}
	}

}
