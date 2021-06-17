using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Ground SuperState")]
    public float rotationSpeed = 4f;
    [Range(0f, 1f)] public float walkRunThreshold = 0.3f;

    [Header("Walk State")]
    public float walkSpeed = 5f;

    [Header("Run State")]
    public float runSpeed = 10f;

    [Header("Jump State")]
    public float jumpVelocity = 15f;
}
