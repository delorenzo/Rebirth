using UnityEngine;
using System.Collections;
public class Ability : MonoBehaviour{
	public GameObject[] Player = new GameObject[5];
	public GameObject obj;
	public int current_player;
	public GameObject flame;

	void Start() {
	}

	void Update() {

		for (var i = 0; i < 5; i++) {
			if (Player[i].activeSelf) { 
				current_player = i;
				break;
			}
		}

		if (Input.GetKeyDown("e")) {
			switch (current_player) {
				case 0:  //egg
				//the egg has no abilities
				break;

				case 1:  //chick
				//the chick just chirps
				break;

				case 2:  //adolescent
				//the adolescent bursts forward
				break;

				case 3: //adult
				break;

				case 4:  //elder
				flame.SetActive(true);
				break;
			}
		}

		if (Input.GetKeyUp("e")) {
			switch (current_player) {
				case 0:  //egg
				//the egg has no abilities
				break;

				case 1:  //chick
				//the chick just chirps
				break;

				case 2:  //adolescent
				//the adolescent bursts forward
				break;

				case 3: //adult
				break;

				case 4:  //elder
				flame.SetActive (false);
				break;
			}
		}
	}


}