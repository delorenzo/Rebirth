using UnityEngine;
using System.Collections;

public class Rebirth : MonoBehaviour {
	public GameObject[] Player;
	public GameObject obj;

	void Update () {
		if (Input.GetKeyDown("r")) {
			for (var i = 0; i < 5; i++) {
				if (Player[i].activeSelf) { 
					obj = Player[i];
					obj.SetActive(false);
					Player[1].transform.position = Player[i].transform.position;
					Player[1].SetActive(true);
					break;
				}
			}
		}
	}

}
