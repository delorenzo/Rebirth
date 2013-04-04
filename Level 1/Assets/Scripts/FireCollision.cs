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
		if (collision == Bush1) {
			Flames1.SetActive(true);
			StartCoroutine(wait(5.0F));
			Bush1.SetActive(false);
		}

		else if (collision == Bush2) {
			Flames2.SetActive(true);
			StartCoroutine(wait(5.0F));
			Bush2.SetActive(false);
		}

		else if (collision == fox) {
			foxflames.SetActive(true);
			StartCoroutine(wait(10.0F));
			fox.SetActive(false);
		}

		else {

		}
	}
	
	IEnumerator wait(float time) {
		yield return new WaitForSeconds(time);
	}
	
	
}