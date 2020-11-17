using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 1.0f;
    public float shiftX = 0.0f;
    public float shiftZ = 0.0f;
    Vector3 movement;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = new Vector3(shiftX, -9.81f, shiftZ).normalized * speed;
        movement = transform.TransformDirection(movement);
        controller.Move(movement);
    }
}
