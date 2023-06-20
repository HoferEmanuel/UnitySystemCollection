using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalDisaster
{
    public static class InputManagerUITest
    {
        bool isPaused = false;
        public static void PauseGame()
        {
            isPaused = !isPaused;
            Debug.Log("pause: " + isPaused);
        }
    }
}
