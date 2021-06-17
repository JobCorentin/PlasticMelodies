using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{

    #region Variables

    protected Vector2 input;
    protected Transform cameraMainTransform;
    protected CharacterController characterController;
    protected Vector3 moveDirection;
    protected Quaternion lookRotation;

    private bool jumpInput;

    #endregion

    public PlayerGroundedState(Player player_, PlayerStateMachine playerStateMachine_, PlayerData playerData_, string animBoolName_) : base(player_, playerStateMachine_, playerData_, animBoolName_)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        #region Instance Acquirements

        cameraMainTransform = Camera.main.transform;
        characterController = player.CharacterController;

        #endregion
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        #region Instance acquirements

        input = player.InputHandler.MovementInput;
        jumpInput = player.InputHandler.JumpInput;

        #endregion

        #region State behavior

        //Calculate the movement direction from the player input.
        moveDirection = new Vector3(input.x, 0, input.y).normalized;

        //Populate the movement direction with the direction the camera is looking at.
        moveDirection = cameraMainTransform.forward * moveDirection.z + cameraMainTransform.right * moveDirection.x;
        moveDirection.y = 0f;


        //Calculate an angle to apply to the player so it looks in the direction he's moving in.
        float lookAngle = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + cameraMainTransform.eulerAngles.y;
        lookRotation = Quaternion.Euler(0f, lookAngle, 0f);

        #endregion

        #region State transitions

        if (jumpInput)
        {
            player.InputHandler.UseJumpInput();
            playerStateMachine.ChangeState(player.JumpState);
        }

        #endregion
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
