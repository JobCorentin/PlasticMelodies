using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    #region Variables

    public PlayerStateMachine StateMachine { get; private set; }

    //Player States
    public PlayerIdleState IdleState { get; private set; }
    public PlayerWalkState WalkState { get; private set; }
    public PlayerRunState RunState { get; private set; }
    public PlayerJumpState JumpState { get; private set; }
    public PlayerFallState FallState { get; private set; }
    public PlayerLandState LandState { get; private set; }

    public Animator PlayerAnimator { get; private set; }
    public PlayerInputHandler InputHandler { get; private set; }
    public CharacterController CharacterController { get; private set; }

    [SerializeField] private PlayerData playerData;

    #endregion

    private void Awake()
    {
        StateMachine = new PlayerStateMachine();

        #region State creation

        IdleState = new PlayerIdleState(this, StateMachine, playerData, "idle");
        WalkState = new PlayerWalkState(this, StateMachine, playerData, "walk");
        RunState = new PlayerRunState(this, StateMachine, playerData, "run");
        JumpState = new PlayerJumpState(this, StateMachine, playerData, "jump");
        FallState = new PlayerFallState(this, StateMachine, playerData, "fall");
        LandState = new PlayerLandState(this, StateMachine, playerData, "land");

        #endregion

    }

    private void Start()
    {

        #region Instance acquirement

        PlayerAnimator = transform.GetChild(0).GetComponent<Animator>();
        InputHandler = GetComponent<PlayerInputHandler>();
        CharacterController = GetComponent<CharacterController>();

        #endregion

        //Set the base state
        StateMachine.Initialize(IdleState);
    }

    private void Update()
    {
        StateMachine.CurrentState.LogicUpdate();
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentState.PhysicsUpdate();
    }
}
