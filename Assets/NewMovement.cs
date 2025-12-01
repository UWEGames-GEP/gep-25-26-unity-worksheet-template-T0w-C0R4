using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMovement : ThirdPersonController
{

    private void onPause(InputValue inputValue)
    {
        if (inputValue.isPressed)
        {
            Debug.Log("pause Game");
        }
    }
}
