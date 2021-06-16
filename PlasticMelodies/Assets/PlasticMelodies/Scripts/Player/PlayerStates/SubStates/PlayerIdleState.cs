using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player player_, PlayerStateMachine playerStateMachine_, PlayerData playerData_, string animBoolName_) : base(player_, playerStateMachine_, playerData_, animBoolName_)
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

        if (input != Vector2.zero)
        {
            playerStateMachine.ChangeState(player.WalkState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
