using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player player;
    protected PlayerStateMachine playerStateMachine;
    protected PlayerData playerData;

    protected float startTime;

    private string animBoolName;

    public PlayerState(Player player_, PlayerStateMachine playerStateMachine_, PlayerData playerData_, string animBoolName_)
    {
        this.player = player_;
        this.playerStateMachine = playerStateMachine_;
        this.playerData = playerData_;
        this.animBoolName = animBoolName_;
    }

    public virtual void Enter()
    {
        DoChecks();

        player.PlayerAnimator.SetBool(animBoolName, true);

        startTime = Time.time;

        Debug.Log(animBoolName);
    }

    public virtual void Exit()
    {
        player.PlayerAnimator.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }

    public virtual void DoChecks()
    {

    }
}
