﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Attributes;
using Leap.Unity;

public class FPSControllerTest : MonoBehaviour {

    public float turnSpeed = 50f;
    public float movementAmount = 0.01f;
    public ExtendedFingerDetector theHand;

    void MouseAiming() {
        var rot = new Vector3(0f, 0f, 0f);
        // rotates Camera Left
        if (Input.GetAxis("Mouse X") < 0) {
            rot.x -= 1;
        }
        // rotates Camera Left
        if (Input.GetAxis("Mouse X") > 0) {
            rot.x += 1;
        }

        // rotates Camera Up
        if (Input.GetAxis("Mouse Y") < 0) {
            rot.z -= 1;
        }
        // rotates Camera Down
        if (Input.GetAxis("Mouse Y") > 0) {
            rot.z += 1;
        }

        transform.Rotate(rot, turnSpeed * Time.deltaTime);
    }

    //void KeyboardMovement() {
    //    var sensitivity = 0.01f;
    //    var movementVector = new Vector3(0f, 0f, 0f);
    //    var hMove = Input.GetAxis("Horizontal");
    //    var vMove = Input.GetAxis("Vertical");
    //    // left arrow
    //    if (hMove < -sensitivity) movementVector.x = -movementAmount;
    //    // right arrow
    //    if (hMove > sensitivity) movementVector.x = movementAmount;
    //    // up arrow
    //    if (vMove < -sensitivity) movementVector.z = -movementAmount;
    //    // down arrow
    //    if (vMove > sensitivity) movementVector.z = movementAmount;
    //    // Using Translate allows you to move while taking the current rotation into consideration
    //    transform.Translate(movementVector);
    //}

    public void moveForward() {
        var movementVector = new Vector3(0f, 0f, 0f);
        movementVector.z = movementAmount;
        transform.Translate(movementVector);
    }

    public void FixedUpdate() {
        if (theHand.IsActive)
            moveForward();
    }
    //void Update() {
    //    MouseAiming();
    //    KeyboardMovement();
    //}
}
