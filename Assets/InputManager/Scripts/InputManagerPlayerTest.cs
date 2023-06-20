using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalDisaster
{
    public static class InputManagerPlayerTest
    {
        //get a reference to the InputManager-Script
        [SerializeField] private InputManager inputManager;
        
        private void Update()
        {
                
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
