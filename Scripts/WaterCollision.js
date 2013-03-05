
function OnTriggerEnter (other : Collider)
{
	//Kill player if he fell in the water
	if (other.GetComponent (ThirdPersonStatus))
	{
		other.GetComponent (ThirdPersonStatus).WaterCollision();
	}
	//Also kill any objects that fell in the water
	else if (other.attachedRigidbody)
		Destroy(other.attachedRigidbody.gameObject);
	// Also kill any enemies
	else if (other.GetType() == typeof(CharacterController))
		Destroy(other.gameObject);
}

// Auto setup the pickup
function Reset ()
{
	if (collider == null)
		gameObject.AddComponent(BoxCollider);
	collider.isTrigger = true;
}

@script AddComponentMenu("Water Collision")