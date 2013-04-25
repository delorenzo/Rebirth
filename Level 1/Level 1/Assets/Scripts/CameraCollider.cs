using UnityEngine;
using System.Collections;

public class CameraCollider : MonoBehaviour {
	public CameraController control;
	
	void OnTriggerEnter(Collider other){
		control.rotationObject.transform.localEulerAngles = new Vector3(control.vRot, control.hRot, -1 * control.rotationObject.transform.localEulerAngles.z);
	}

}
