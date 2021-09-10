using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour{

    public static InputManager Instance;
    PlayerInput input;

    void Awake()
    {
        if (Instance != null)
            GameObject.Destroy(Instance);
        else
            Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start(){
        input = GetComponent<PlayerInput>();
    }

    void OnAttack (InputValue value){
        Debug.Log("Attack!");
    }


    void OnMove(InputValue value){
        Vector2 movement = (Vector2)value.Get();
        GameManager.Instance.playerManager.PlayerControllerInstance.movement.SetHorizontalPosition(movement.x);
    }

    void OnExit(InputValue value){
        GameManager.Instance.ExitGame();
    }

    void OnJump(InputValue value){
        GameManager.Instance.playerManager.PlayerControllerInstance.PlayerJump();
    }



}
