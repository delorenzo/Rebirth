using UnityEngine;
using System.Collections;

public class EndLevel1 : MonoBehaviour {
	public GameObject obj;
	public GameObject fox;
	void OnTriggerEnter(Collider col) {
		obj = col.gameObject;
		if (col.gameObject.CompareTag ("Player") && !(fox.activeSelf)) {
			Application.LoadLevel("LVL2_MAIN");  
		}
	}
}
