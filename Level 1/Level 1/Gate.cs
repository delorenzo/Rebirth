using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {
	public GameObject obj;
	public Inventory inv;
	public OpenGate gate;
	void OnCollisionEnter(Collision collision) {
		obj = collision.gameObject;
		Debug.Log("I'm colliding with " + collision.gameObject.name);
		if (collision.gameObject.CompareTag ("Player")) {
			if (inv.hasItem("Key")) {
				inv.removeItem("Key");
				gate.setActive(true);
				gameObject.setActive(false);
			}
		}
	}
	
}
