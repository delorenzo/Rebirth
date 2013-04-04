using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	public GameObject[] inventory = new GameObject[5];
	int inventorySize = 0;
	public string objname;
	
	public void addItem(GameObject item) {
		inventory[inventorySize] = item;
		inventorySize++;
		item.SetActive (false);
	}
	
	public bool hasItem(string itemname) {
		for (int j = 0; j < inventorySize; j++) {
			if (inventory[j].name == itemname) { return true;}
		}
		return false;
	}
	
	public void removeItem(string itemname) {
		for (int j = 0; j < inventorySize; j++) {
			if (inventory[j].name == itemname) { 
				inventory[j] = null;
				return;
			}
		}
	}
}

