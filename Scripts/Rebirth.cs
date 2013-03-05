using UnityEngine;
using System.Collections;
public class Rebirth : MonoBehaviour {
	public int index = 0;
	
	public void Update () {
		if (Input.GetKeyDown("R")) {
			this.renderer.enabled = false;
		}
		GameObject.Find("3rd Person Controller 0").renderer.enabled = true;
		GameObject.Find("3rd Person Controller 0").transform.position = this.transform.position;
		GameObject.Find("3rd Person Controller 0").transform.rotation = this.transform.rotation;
	}

}
