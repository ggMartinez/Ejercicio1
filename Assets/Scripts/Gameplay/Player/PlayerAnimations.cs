using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] PlayerController playerController;

    void Start(){
        playerController = GetComponent<PlayerController>();
    }
}
