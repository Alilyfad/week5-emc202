using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputmanager : MonoBehaviour
{

    private Playercontrols playercontrols;
    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    private void OnEnable()
    {
        if (playercontrols == null)
        {
            playercontrols = new Playercontrols();
            //when we hit WASD, we will record the movement to a variable
            playercontrols.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playercontrols.Enable();
    }

    private void OnDisable()
    {
        playercontrols.Disable();
    }

    private void HandleAllInput()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
