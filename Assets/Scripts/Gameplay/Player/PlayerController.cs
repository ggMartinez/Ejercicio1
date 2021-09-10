using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerController : MonoBehaviour
{
    public PlayerMovement movement;
    public PlayerAnimations animations;
    public PlayerSounds sounds;
    public PlayerEffects effects;
    public PlayerAttack attack;


    void Start()
    {
        this.movement = GetComponent<PlayerMovement>();
        this.animations = GetComponent<PlayerAnimations>();
        this.sounds = GetComponent<PlayerSounds>();
        this.effects = GetComponent<PlayerEffects>();
        this.attack = GetComponent<PlayerAttack>();
    }   



    public void PlayerJump()
    {
        movement.Jump();
    }

}
