
using UnityEngine;
using System.Collections;

public class ItemCollision : MonoBehaviour {
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("item")) {
        	Inventory inv;
        	inv = GetComponent<Inventory>();
			inv.addItem(col.gameObject);
			Destroy(col.gameObject);
		
		}
    } 
}