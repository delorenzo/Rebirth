using UnityEngine;
using System.Collections;

public class WaterCollision : MonoBehaviour {
	public GameObject spawn;
	//public GameObject[] Player = new GameObject[5];
	public GameObject [] Player;
	void Start() {
		spawn = GameObject.Find ("Spawn");
	}

	void OnParticleCollision(GameObject collision) {
		if (collision.transform.tag == "Player") {
			//check if adolescent 
			if (collision.gameObject.name == "PLP2") {
				if (Input.GetKey(KeyCode.LeftShift)) {
					return;
				}
			}
			reset ();
		}
	}
	void OnTriggerEnter(Collider other) {
		//Kill player if he fell in the water
		if (other.GetType() == typeof(CharacterController)) {
			reset ();
		}
		//Also kill any objects that fell in the water
		else {
			Destroy(other.gameObject);
		}
	}
	
	void reset() {
		for (var i = 0; i < 5; i++) {
				if (Player[i].activeSelf) {
					//otherwise activate egg and deactivate game object
					Player[i].SetActive(false);
					Player[0].transform.position = spawn.transform.position;
					Player[0].SetActive(true);
					break;
				}
			}
	}
	
}