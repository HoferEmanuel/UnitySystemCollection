using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalDisaster
{
    public static class InputManagerPlayerTest
    {
        [SerializeField] private InputManager inputManager;
        [SerializeField] private Vector3 moveDirection;

        private void Awake()
        {
            //get a reference to the InputManager-Script
            inputManager = GetComponent<InputManager>();    
        }
        
        private void Update()
        {
            //read an input-value directly from your input-manager
        }
        
        public void Dash()
        {
            Debug.Log("Dash input");
        }

        public void Jump()
        {
            Debug.Log("Dash input");
        }
    }
}
