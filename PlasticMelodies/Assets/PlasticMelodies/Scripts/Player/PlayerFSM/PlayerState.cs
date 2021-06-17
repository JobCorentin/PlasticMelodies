using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The base code all the player states inherites from.
/// </summary>
public class PlayerState
{

    #region Variables

    protected Player player;
    protected PlayerStateMachine playerStateMachine;
    protected PlayerData playerData;
    protected float startTime;
    private string animBoolName;

    #endregion

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

        //Trigger new animation.
        player.PlayerAnimator.SetBool(animBoolName, true);

        //To keep track of how long the player as been in the current state.
        startTime = Time.time;

        Debug.Log("current state : " + animBoolName);
    }

    public virtual void Exit()
    {
        //End current animation
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
