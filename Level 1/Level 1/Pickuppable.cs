using UnityEngine;
using System.Collections;

public class Pickuppable : MonoBehaviour {
	public GameObject obj;
	public GameObject player;
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			player.getComponent(Inventory).addItem(obj);
			Destroy (obj);
		}
	}
	
}