
using UnityEngine;
using System.Collections;

public class ItemCollision : MonoBehaviour {
	public GameObject obj;
	void OnCollisionEnter(Collision col) {
		obj = col.gameObject;
		if (col.gameObject.CompareTag("item")) {
        	Inventory inv;
        	inv = GetComponent<Inventory>();
			inv.addItem(col.gameObject);
			Destroy(col.gameObject);
		
		}
    } 
}