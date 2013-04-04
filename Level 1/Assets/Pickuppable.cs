using UnityEngine;
using System.Collections;

public class Pickuppable : MonoBehaviour {
	public GameObject obj;
	public Inventory inv;
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		if (other.CompareTag ("Player")) {
			inv = GetComponent("Inventory") as Inventory;
			inv.addItem(obj);
			obj.SetActive (false);
		}
	}
	
}