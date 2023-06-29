using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public bool fire;
    public Vector2 inputVector;
    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started) {fire = true; }
            
        if (context.performed)
        { fire = true; }
        if (context.canceled)
        { fire = false; }
    }
    public void SetMoveMentVector(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
    }
    
}
