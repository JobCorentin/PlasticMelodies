using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : PlayerGroundedState
{
    public PlayerRunState(Player player_, PlayerStateMachine playerStateMachine_, PlayerData playerData_, string animBoolName_) : base(player_, playerStateMachine_, playerData_, animBoolName_)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        #region state behavior

        //Move the player according to the direction calculated in ground superstate.
        characterController.Move(moveDirection * playerData.runSpeed * Time.deltaTime);

        //Apply and lerp the player look angle to have a smooth transition.
        player.transform.rotation = Quaternion.Lerp(player.transform.rotation, lookRotation, playerData.rotationSpeed * Time.deltaTime);

        #endregion

        #region state transitions

        if (input.magnitude == 0f)
        {
            playerStateMachine.ChangeState(player.IdleState);
        }
        else if (input.magnitude == playerData.walkRunThreshold)
        {
            playerStateMachine.ChangeState(player.WalkState);
        }

        #endregion
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
