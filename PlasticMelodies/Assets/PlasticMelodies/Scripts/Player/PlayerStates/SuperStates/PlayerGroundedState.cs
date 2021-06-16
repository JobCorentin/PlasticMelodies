using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    protected Vector2 input;

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
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        input = player.InputHandler.MovementInput;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
