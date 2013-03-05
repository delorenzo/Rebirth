using UnityEngine;
using System.Collections;

public class Abilities : MonoBehaviour
{
	int age;
	// Use this for initialization
	void Start ()
	{
		//find out which phoenix stage is active
		age = 0;
		for (int i = 0; i < 5; i++) {
			if (GameObject.Find("3rd Person Controller " + i).renderer.enabled) {
				age = i;	
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (age) {
		case 0:  break; //egg has no ability
		case 1:  {
			//squeak noise
			AudioSource.PlayClipAtPoint(squeak, transform.position);	
			break;
		}
		case 2: {
			//burst
			break;
		}
		case 3: {
			//fly
			break;
		}
		case 4:  {
			//fire	
			break;
		}
		
			
		}
	}
}

