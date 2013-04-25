using UnityEngine;
using System.Collections;

public class Rebirth : MonoBehaviour {
	public CameraController control;
	
	void OnTriggerEnter(Collider other){
		control.rotationObject.transform.localEulerAngles = new Vector3(vRot, hRot, -1 * rotationObject.transform.localEulerAngles.z);
	}

}
