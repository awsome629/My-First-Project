using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = Vector3.zero;
        //X - left and right
        moveVector.x = Input.GetAxis("Horizontal");
        //Y - up and down
        //Z - forward and backward
        controller.Move(moveVector * Time.deltaTime);
	}
}
