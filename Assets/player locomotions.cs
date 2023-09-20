using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlocomotions : MonoBehaviour
{
    private inputmanager inputManager;
    private Vector3 moveDirection;
    private Transform cameraObject;
    private Rigidbody rigidBody;

    private void Awake()
    {
        inputManager = GetComponent<inputmanager>();
        rigidBody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {

    }

    private void HandleRotation()
    {

    }
}
