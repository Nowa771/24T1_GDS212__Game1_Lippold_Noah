using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f; // Speed of the car
    public float rotationSpeed = 100f; // Rotation speed of the car
    public Transform centerOfMass; // Center of mass of the car 

    private Rigidbody rb; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (centerOfMass != null)
            rb.centerOfMass = centerOfMass.localPosition; // center of mass
    }

    private void FixedUpdate()
    {
        // Get input from user
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the car forward and backward
        rb.AddForce(transform.forward * verticalInput * speed);

        // Rotate the car left and right
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.fixedDeltaTime);
    }
}

