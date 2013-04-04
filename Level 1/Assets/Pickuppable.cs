using UnityEngine;
using System.Collections;

public class Pickuppable : MonoBehaviour {
	public GameObject obj;
	public Inventory inv;
	void OnTriggerEnter(Collider other) {
		obj = other.gameObject;
		//Debug.Log("I'm attached to " + gameObject.name);
		if (other.gameObject.CompareTag ("Player")) {
			inv.addItem(gameObject);
		}
	}
	
}