using System;
using UnityEngine;
using System.Collections;

[Serializable]
public class AxisSettings
{
	public float sensitivity = 15;
	public float minimumAngle = -360;
	public float maximumAngle = 360;
}

[Serializable]
public class ScrollingSettings
{
	public bool enableMouseWheelScrolling = true;
	public float smoothing = 0.2f;
	public float sensitivity = 1;
	public float innerLimit = 1;
	public float outerLimit = 10;
	public float baseFollowDistance = 2;
}

public class CameraController : MonoBehaviour {

	private GameObject player;
	[HideInInspector]
	public GameObject rotationObject;
	[HideInInspector]
	public GameObject scrollerObject;
	public float smoothing = 15.0f;
	public AxisSettings horizontal, vertical;
	public ScrollingSettings scrolling;
	public bool invert;
	
	private float hRot, vRot;
	private float followDistance;
	int current;
	
	public Age age;

	// Use this for initialization
	void Awake () {
		followDistance = scrolling.baseFollowDistance;
		rotationObject = GameObject.Find("Cam.RotationPoint");
		scrollerObject = GameObject.Find("Cam.Scroller");
		
		
		vRot = rotationObject.transform.localEulerAngles.x;
		hRot = rotationObject.transform.localEulerAngles.y;
		
		scrollerObject.transform.localPosition = new Vector3(
			scrollerObject.transform.localPosition.x,
			scrollerObject.transform.localPosition.y,
			-followDistance);
		player = age.GetPlayer ();
		Update ();
	}
	
	// Update is called once per frame
	void Update () {
		hRot += Input.GetAxis("Mouse X") * horizontal.sensitivity;
		hRot = AngleClamp(hRot, horizontal.minimumAngle, horizontal.maximumAngle);
		if (invert) {
			vRot -= Input.GetAxis("Mouse Y") * vertical.sensitivity;
		} else {
			vRot += Input.GetAxis("Mouse Y") * vertical.sensitivity;
		}
		vRot = AngleClamp(vRot, vertical.minimumAngle, vertical.maximumAngle);
		
		rotationObject.transform.localEulerAngles = new Vector3(vRot, hRot, rotationObject.transform.localEulerAngles.z);
		
		if (scrolling.enableMouseWheelScrolling) {
			followDistance += Input.GetAxis("Mouse ScrollWheel") * scrolling.sensitivity;
			
			followDistance = Mathf.Clamp(followDistance, scrolling.innerLimit, scrolling.outerLimit);
			
			Transform t = scrollerObject.transform;
			t.localPosition = new Vector3(
				t.localPosition.x,
				t.localPosition.y,
				Mathf.Lerp(t.localPosition.z, -followDistance, scrolling.smoothing));
		}
		player = age.GetPlayer ();
	}
	
	private float AngleClamp (float angle, float min, float max) {
		if (angle < -360) {
			angle += 360;
		}
		if (angle > 360) {
			angle -= 360;
		}
		
		return Mathf.Clamp(angle, min, max);
	}
	
	// follow in LateUpdate to account for player movement
	void LateUpdate () {
		transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * smoothing);
	}
}
