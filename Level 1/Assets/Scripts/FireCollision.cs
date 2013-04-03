using UnityEngine;
using System.Collections;

public class FireCollision : MonoBehaviour {
	public GameObject Flames1;
	public GameObject Flames2;
	public GameObject fox;
	public GameObject foxflames;
	public GameObject Bush1;
	public GameObject Bush2;
	public GameObject elder;
	public GameObject obj;
	RaycastHit hit;
	
	
	void OnParticleCollision(GameObject collision) {
		obj = collision;
		if (collision == Bush1) {
			Flames1.SetActive(true);
			StartCoroutine(wait());
			Bush1.SetActive(false);
		}

		else if (collision == Bush2) {
			Flames2.SetActive(true);
			StartCoroutine(wait());
			Bush2.SetActive(false);
		}

		else if (collision == fox) {
			StartCoroutine(wait());
			fox.SetActive(false);
		}

		else {

		}
	}
	
	IEnumerator wait() {
		yield return new WaitForSeconds(5);
	}
	
	/*
	void Update() {
		if (Physics.Raycast(elder.transform.position, Vector3.forward, out hit)) {
			
			if (hit.collider.name == "Bush1") {
				Flames1.SetActive(true);
				timer = 0;
				while (timer < 3) {
					timer += Time.deltaTime;
				}
				Destroy (Bush1);
			}
			else if (hit.collider.name == "Bush2") {
				Flames2.SetActive(true);
				timer = 0;
				while (timer < 3) {
					timer += Time.deltaTime;
				}
				Destroy (Bush2);
			}
			else if (hit.collider.name == "ShadowFox") {
				foxflames.SetActive(true);
				timer = 0;
				while (timer < 3) {
					timer += Time.deltaTime;
				}
				Destroy (fox);
			}
			else {
				
			}
		}
	}
	*/
	
}