﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float animationDuration = 3.0f;


    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }
        moveVector = Vector3.zero;

        //X - left and right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //Y - up and down
        //Z - forward and backward
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
	}
}
