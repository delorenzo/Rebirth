using UnityEngine;
using System.Collections;

public class FireCollision : MonoBehaviour {
	public GameObject Flames1;
	public GameObject Flames2;
	public GameObject fox;
	public GameObject foxflames;
	public GameObject Bush1;
	public GameObject Bush2;
	
	
	
	void OnParticleCollision(GameObject collision) {
		if (collision == Bush1 && (!(Flames1.activeSelf))) {
			StartCoroutine(burn (Bush1, Flames1));
		}

		else if (collision == Bush2 && (!(Flames2.activeSelf))) {
			StartCoroutine(burn (Bush2, Flames2));
		}

		else if (collision == fox && (!(foxflames.activeSelf))) {
			StartCoroutine(burn (fox, foxflames));
		}

		else {

		}
	}
	
	
	IEnumerator burn(GameObject obj, GameObject flames) {
		flames.SetActive (true);
		yield return new WaitForSeconds(2);
		obj.SetActive (false);
	}
	
	
}