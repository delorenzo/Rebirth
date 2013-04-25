using UnityEngine;
using System.Collections;

public class FireCollision : MonoBehaviour {
	public GameObject Flames1;
	public GameObject Flames2;
	public GameObject fox;
	public GameObject foxflames;
	public GameObject Bush1;
	public GameObject Bush2;
	public GameObject Bush3;
	
	
	void OnParticleCollision(GameObject collision) {
		if (collision == Bush1) {
			StartCoroutine(burn (Bush1, Flames1));
		}

		else if (collision == Bush2) {
			StartCoroutine(burn (Bush2, Flames2));
		}
		else if (collision == Bush3) {
			StartCoroutine(burn (Bush3, Flames2));
		}

		else if (collision == fox) {
			StartCoroutine(burn (fox, foxflames));
		}

		else {

		}
	}
	
	
	IEnumerator burn(GameObject obj, GameObject flames) {
		//print ("Burning " + obj.name);
		flames.SetActive (true);
		yield return new WaitForSeconds(2);
		//print ("Setting inactive" + obj.name);
		obj.SetActive (false);
	}
	
	
}