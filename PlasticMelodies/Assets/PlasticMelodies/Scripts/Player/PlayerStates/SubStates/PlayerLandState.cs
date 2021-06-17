using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLandState : PlayerGroundedState
{
    public PlayerLandState(Player player_, PlayerStateMachine playerStateMachine_, PlayerData playerData_, string animBoolName_) : base(player_, playerStateMachine_, playerData_, animBoolName_)
    {
    }
}
