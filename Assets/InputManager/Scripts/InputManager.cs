using UnityEngine;

namespace DigitalDisaster
{
    public class InputManager : MonoBehaviour
    {
        //values like sprinting and movement get read inside the InputManagerPlayerTest

        //Generated Input-System Script
        PlayerInputActions controls;

        //control-scheme
        PlayerInputActions.PlayerActionsActions playerControls;
        PlayerInputActions.UIActionsActions uiControls;

        private void Awake()
        {
            //create new object for playerinput-script
            controls = new PlayerInputActions();

            //get reference to specific inputs
            playerControls = controls.PlayerActions;
            uiControls = controls.UIActions;

            AssignPlayerControls();
            AssignUIControls();
        }

        private void AssignPlayerControls()
        {
            //handle jump
            playerControls.Jump.performed += context => InputManagerPlayerTest.Jump();
            //handle dash
            playerControls.Dash.performed += context => InputManagerPlayerTest.Jump();
        }

        private void AssignUIControls()
        {
            //handle pause
            uiControls.Pause.performed += context => InputManagerUITest.PauseGame();
        }

        private void OnEnable()
        {
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }
    }
}
