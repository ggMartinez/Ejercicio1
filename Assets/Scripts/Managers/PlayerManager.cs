using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerManager : MonoBehaviour{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform spawnLocation;
    public PlayerController PlayerControllerInstance;

    GameObject playerObject;

   
    public void SpawnPlayer()
    {
        PlayerControllerInstance = null;
        CinemachineVirtualCamera vcam = GameObject.Find("CineMachineVirtualCamera").GetComponent<CinemachineVirtualCamera>();

        playerObject = Instantiate(playerPrefab, spawnLocation.position, Quaternion.identity);
        playerObject.transform.parent = GameObject.Find("Player").transform;
        PlayerControllerInstance = playerObject.GetComponent<PlayerController>();

        playerObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        
        vcam.m_Follow = playerObject.transform;

    }


}
