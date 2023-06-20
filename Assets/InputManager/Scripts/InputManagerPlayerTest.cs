using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalDisaster
{
    public static class InputManagerPlayerTest
    {
        // This script is only a showcase and has no real purpose

        [Header("References")]
        [SerializeField] private InputManager inputManager;

        [Header("Movement")]
        [SerializeField] private Vector2 moveDirection;
        [SerializeField] private float currentMovementSpeed = 0;
        [SerializeField] private float walkSpeed = 4;
        [SerializeField] private float sprintSpeed = 8;

        private void Awake()
        {
            //get a reference to the InputManager-Script
            inputManager = GetComponent<InputManager>();
        }
        
        private void Update()
        {
            //read an input-value from input-manager
            moveDirection = inputManager.playerControls.Move.ReadValue<Vector2>();
            Debug.Log(moveDirection);
        }
        
        public void HandleMovementSpeed()
        {   
            //set boolean true if sprinting-input is pressed
            bool isSprinting = inputManager.playerControls.Sprint.ReadValue<float>() > 0;
            Debug.Log("player sprinting: " + isSprinting);

            if(isSprinting)
                currentMovementSpeed = sprintSpeed;
            else
                currentMovementSpeed = walkSpeed;
        }

        public void Dash() => Debug.Log("Dash input");

        public void Jump() => Debug.Log("Dash input");
    }
}
