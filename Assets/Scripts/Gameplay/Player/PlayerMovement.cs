using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField,Range(1,800)] float jumpStrenght;
    [SerializeField] float walkSpeed;

    float receivedInput;
    Rigidbody2D rigidBody;
    
    void Start(){
        playerController = GetComponent<PlayerController>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update(){
        Move();  
    }

    void Move(){
        flip(receivedInput);
        rigidBody.velocity = new Vector2(receivedInput * walkSpeed , rigidBody.velocity.y);
    }


    void flip(float x){
        if (x < 0) playerController.transform.rotation = Quaternion.Euler(0, 180, 0);
        if (x > 0) playerController.transform.rotation = Quaternion.identity;
    }


    public void SetHorizontalPosition(float position){
        this.receivedInput = position;
    }

    public void Jump(){
        rigidBody.AddForce(Vector3.up * (jumpStrenght * 5));
    }
}
