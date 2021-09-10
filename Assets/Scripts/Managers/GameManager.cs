using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerManager playerManager;

    void Awake()
    {
        if (Instance != null)
            GameObject.Destroy(Instance);
        else
            Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start(){
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        playerManager.SpawnPlayer();
    }

    
    public void ExitGame(){
        Application.Quit();
    }


}