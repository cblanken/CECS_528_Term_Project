using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour
{
    public float _speed = 9.0f;
    public float gravity = -9.8f;
    [SerializeField] private float JumpHeight = 4;
    [SerializeField] private Vector3 _velocity;
    private CharacterController _charController;


    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (_charController.isGrounded && _velocity.y < 0)
        {
            _velocity.y = 0f;
        }

        //transform.Translate(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * _speed * Time.deltaTime);
        float deltaX = Input.GetAxis("Horizontal") * _speed;
        float deltaZ = Input.GetAxis("Vertical") * _speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, _speed);
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        // Apply gravity
        _velocity.y += gravity * Time.deltaTime;
        _velocity = Vector3.ClampMagnitude(_velocity, 53);
        _charController.Move(_velocity * 1.5f * Time.deltaTime);


        // Sprint function
        if (Input.GetKey(KeyCode.LeftShift) && _charController.isGrounded)
        {
            _speed = 14.0f;
        }
        else
        {
            _speed = 7.0f;
        }

        // Jump function
        if (Input.GetButtonDown("Jump") && _charController.isGrounded)
        {
            _velocity.y += Mathf.Sqrt(JumpHeight * -2f * gravity);
        }
    }
}