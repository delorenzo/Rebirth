
// sound effects.
var struckSound: AudioClip;
var health:  int;
function Awake()
{
	
	levelStateMachine = FindObjectOfType(LevelStatus);
	if (!levelStateMachine)
		Debug.Log("No link to Level Status");
	
	
}

// Utility function used by HUD script:
function GetRemainingItems() : int
{
	return remainingItems;
}

function ApplyDamage (damage : int)
{
	if (struckSound)
		AudioSource.PlayClipAtPoint(struckSound, transform.position);	// play the 'player was struck' sound.

	health -= damage;
	if (health <= 0)
	{
		Rebirth();
	}
}



function WaterCollision ()
{
	Rebirth();
	return;
}

function Rebirth ()
{
		this.renderer.enabled = false;
	
		GameObject.Find("3rd Person Controller 0").renderer.enabled = true;
		GameObject.Find("3rd Person Controller 0").transform.position = this.transform.position;
		GameObject.Find("3rd Person Controller 0").transform.rotation = this.transform.rotation;
	

}