public class WaterCollision : MonoBehavior {
	
	void OnCollisionEnter() {
			// Player fall out!
	if (other.GetComponent (ThirdPersonStatus))
	{
		other.GetComponent (ThirdPersonStatus).FalloutDeath();
	}
	// Kill all rigidibodies flying through this area
	// (Props that fell off)
	else if (other.attachedRigidbody)
		Destroy(other.attachedRigidbody.gameObject);
	// Also kill all character controller passing through
	// (enemies)
	else if (other.GetType() == typeof(CharacterController))
		Destroy(other.gameObject);
		
	}
	
	
}
