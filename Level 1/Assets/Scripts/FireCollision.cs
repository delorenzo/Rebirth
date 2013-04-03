using UnityEngine;
using System.Collections;

public class FireCollision : MonoBehaviour {
	public GameObject Flames1;
	public GameObject Flames2;
	public GameObject fox;
	public GameObject foxflames;
	public GameObject Bush1;
	public GameObject Bush2;
	public string obj;
	public Vector3 origin;
	float timer;
	RaycastHit hit;
	
	/*
	void OnParticleCollision(GameObject collision) {
		obj = collision.transform.tag;
		if (collision.transform.tag == "Bushes") {
			Flames1.SetActive(true);
			timer = 0;
			while (timer < 3) {
				timer += Time.deltaTime;
			}
			Bush1.SetActive(false);
		}

		else if (collision.transform.tag == "Bushes") {
			Flames2.SetActive(true);
			timer = 0;
			while (timer < 3) {
				timer += Time.deltaTime;
			}
			Bush2.SetActive(false);
		}

		else if (collision.transform.tag == "ShadowFox") {
			foxflames.SetActive(true);
			timer = 0;
			while (timer < 3) {
				timer += Time.deltaTime;
			}
			fox.SetActive(false);
		}

		else {

		}
	}
	
	*/
	
	void Update() {
		if (Physics.Raycast(origin, Vector3.forward, out hit)) {
			obj = hit.collider.name;
			if (hit.collider.name == "BushCube1") {
				Flames1.SetActive(true);
				timer = 0;
				while (timer < 3) {
					timer += Time.deltaTime;
				}
				Destroy (Bush1);
			}
			else if (hit.collider.name == "BushCube2") {
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
	
}