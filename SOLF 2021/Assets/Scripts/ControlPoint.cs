using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    float xRotation, yRotation = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;

    public float shootPower = 30f;

    void Update()
    {
        transform.position = ball.position;

        if (Input.GetMouseButton(0))
        {
            xRotation += Input.GetAxis("Mouse X") * rotationSpeed;
            yRotation += Input.GetAxis("Mouse Y") * rotationSpeed;

            if (yRotation < -35f)
            {
                yRotation = -35f;
            }

            transform.rotation = Quaternion.Euler(yRotation, xRotation, 0f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            ball.velocity = transform.forward * shootPower;
        }
    }
}
