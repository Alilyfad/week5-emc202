using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{

    public static playermanager instance { get; private set; }
    public GameObject player;
    inputmanager inputManager;
    playerlocomotions playerLocomotion;
    public float movementSpeed;
    public float rotationSpeed;

    private void Awake()
    {
        if (instance != null && instance != this) { Destroy(this); }
        else { instance = this; }
        inputManager = player.GetComponent<inputmanager>();
        playerLocomotion = player.GetComponent <playerlocomotions>();
    }

    private void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }
}
