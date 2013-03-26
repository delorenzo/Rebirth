using UnityEngine;
using System.Collections;

public class WaterCollision : MonoBehaviour {
	public GameObject[] Player = new GameObject[5];
	void OnTriggerEnter(Collider other) {
		//Kill player if he fell in the water
		if (other.GetType() == typeof(CharacterController)) {
			//find active character
			for (var i = 0; i < 5; i++) {
				if (Player[i].activeSelf) {
					//check if adolescent 
					if (i == 2) {
						if (Player[i].GetComponent(ThirdPersonController).isBursting()) {
							break;
						}
					}

					//otherwise activate egg and deactivate game object
					Player[i].setActive(false);
					Player[0].transform.position = Player[i].transform.position;
					Player[0].setActive(true);
					break;
				}
			}
		}
		//Also kill any objects that fell in the water
		else {
			Destroy(other.gameObject);
		}
	}
}