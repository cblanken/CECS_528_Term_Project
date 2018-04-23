using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour {
	public float speed = 9.0f;
	public float gravity = -9.8f;
	private CharacterController _charController;


	void Start() {
		_charController = GetComponent<CharacterController>();
	}
	
	void Update() {
		//transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude(movement, speed);

		movement.y = gravity;

		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		_charController.Move(movement);


		// Sprint function
		if (Input.GetKey (KeyCode.LeftShift) && _charController.isGrounded) {
			speed = 14.0f;
		} else {
			speed = 7.0f;
		}
	}
}
