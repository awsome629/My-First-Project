using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;
    private float animationDuration = 3.0f;
    private bool isDead = false;
    private Rigidbody rb;
    private float startTime;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        startTime = Time.time;
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead)
        
            return;
        
        if(Time.time - startTime < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //X - left and right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x > Screen.width / 2)
                moveVector.x = speed;
            else
                moveVector.x = -speed;
        }
        //Y - up and down
        moveVector.y = verticalVelocity;
        //Z - forward and backward
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
	}
    public void SetSpeed(int modifier)
    {
        speed = 5.0f + modifier;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //if (rb.velocity == Vector3.zero)
        if (hit.gameObject.tag == "Enemy")
            Death();
    }
    private void Death()
    {
        Time.timeScale = 0;
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
