using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{

    #region Variables

    public Vector2 MovementInput { get; private set; }
    public bool JumpInput { get; private set; }

    #endregion

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (context.started)
            {
                JumpInput = true;
            }
        }
    }

    /// <summary>
    /// Call this to set JumpInput back to false after using it to transition states.
    /// </summary>
    public void UseJumpInput() => JumpInput = false;
}
