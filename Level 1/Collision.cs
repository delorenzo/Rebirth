
using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.compareTag("item")) {
        	Inventory inv;
        	inv = GetComponent<Inventory>();
			inv.addItem(col.gameObject);
			Destroy(col.gameObject);
		
		}
    } 
}