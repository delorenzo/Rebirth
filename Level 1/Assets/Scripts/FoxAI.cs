using UnityEngine;
using System.Collections;

public class FoxAI : MonoBehaviour {
	//stats
	public float attackTurnTime = 0.7f;
	public float rotateSpeed = 120.0f;
	public float attackSpeed = 5.0f;
	public float attackRotateSpeed = 20.0f;
	public float attackDistance = 17.0f;
	public float dmg = 5.0f;
	public float idleTime = 1.6f;
	float runTime = 2.0f;
	Vector3 attackPos = new Vector3 (0.4f, 0.0f, 0.7f);
	float lastAttack = 0.0f;
	float attackRadius = 1.1f;
	
	//sounds
	public AudioClip idleSound;
	public AudioClip attackSound;
	
	//private bool isAttacking = false;
	
	public Transform target;
	
	//fox controller
	public CharacterController characterController;
	
	// Use this for initialization
	void Start () {
		if (!target) {
			target = GameObject.FindWithTag("Player").transform;
		}
		
		while (true) {
			Idle();
			Attack();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!target) {
			target = GameObject.FindWithTag("Player").transform;
		}
	}
	
	IEnumerator Idle() {
		if (idleSound) {
			if (audio.clip != idleSound) {
			audio.Stop();
			audio.clip = idleSound;
			audio.loop = true;
			audio.Play();	// play the idle sound.
			}
		}
		
		yield return new WaitForSeconds(idleTime);
		
		while (true) {
			target = GameObject.FindWithTag("Player").transform;
			characterController.SimpleMove(Vector3.zero);
			yield return new WaitForSeconds(0.2f);
		
			var offset = transform.position - target.position;
			
			if (offset.magnitude < attackDistance) {
				return true;
			}
		}
	}
	
	float Rotate(Vector3 targetPos, float rotateSpeed) {
		Vector3 relative = transform.InverseTransformPoint(targetPos);
		float angle = Mathf.Atan2 (relative.x, relative.z) * Mathf.Rad2Deg;
		float maxRotation = rotateSpeed * Time.deltaTime;
		float clampedAngle = Mathf.Clamp(angle, -maxRotation, maxRotation);
		transform.Rotate(0, clampedAngle, 0);
		return angle;	
	}
	
	void Attack() {
		//isAttacking = true;
		
		if (attackSound) {
			if (audio.clip != attackSound){
				audio.Stop();	// stop the idling audio so we can switch out the audio clip.
				audio.clip = attackSound;
				audio.loop = true;	// change the clip, then play
				audio.Play();
			}
		}
		
		
		float time = 0.0f;
		float angle = 180.0f;
		Vector3 direction;
		while (angle > 5 || time < attackTurnTime) {
			time += Time.deltaTime;
			angle = Mathf.Abs(Rotate(target.position, rotateSpeed));
			float move = Mathf.Clamp01((90 - angle) / 90);
			direction = transform.TransformDirection(Vector3.forward * attackSpeed * move);
			characterController.SimpleMove(direction);
		}
		
		float timer = 0.0f;
		bool lostSight = false;
		
		while (timer < runTime) {
			angle = Rotate(target.position, attackRotateSpeed);
			if (Mathf.Abs(angle) > 40) {
				lostSight = true;
			}
			if (lostSight) {
				timer += Time.deltaTime;	
			}
			direction = transform.TransformDirection(Vector3.forward * attackSpeed);
			characterController.SimpleMove(direction);
			
			Vector3 pos = transform.TransformPoint(attackPos);
			
			if (Time.time > lastAttack + 0.3 && (pos-target.position).magnitude < attackRadius) {
				target.SendMessage("ApplyDamage", dmg);
				lastAttack = Time.time;
				
			}
			
			if (characterController.velocity.magnitude < attackSpeed * 0.3) {
				break;
			}
		}
		
		//isAttacking = false;
		
	}
}
