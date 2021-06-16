using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine { get; private set; }

    public PlayerIdleState IdleState { get; private set; }
    public PlayerWalkState WalkState { get; private set; }


    public Animator PlayerAnimator { get; private set; }
    public PlayerInputHandler InputHandler { get; private set; }
    public CharacterController characterController { get; private set; }


    [SerializeField] private PlayerData playerData;


    private void Awake()
    {
        StateMachine = new PlayerStateMachine();

        IdleState = new PlayerIdleState(this, StateMachine, playerData, "idle");

        WalkState = new PlayerWalkState(this, StateMachine, playerData, "walk");
        
    }
    
    private void Start()
    {
        PlayerAnimator = transform.GetChild(0).GetComponent<Animator>();
        InputHandler = GetComponent<PlayerInputHandler>();
        characterController = GetComponent<CharacterController>();

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

    public void SetVelocityHorizontal(float velocity)
    {

    }
}
