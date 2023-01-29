using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyTargetPath : MonoBehaviour
{
    private Transform targetPos;

    public List<Transform> roomLocations;
    
    public float delayInSeconds;

    private void Start()
    { 
        // destinationNode.transform.position = targetPos.transform.position;
        RoomSet();
        TeleportToLocation();
       
    }

    private void Update()
    {


    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayInSeconds);
    }

    void RoomSet()
    {
        Debug.Log("Room is setting");
        int pos = Random.Range(0, roomLocations.Count);
        targetPos.position = roomLocations[pos].position;
        Debug.Log(targetPos.gameObject.name + "is the room");
        TeleportToLocation();
        StartCoroutine(Delay());
    }

    void TeleportToLocation()
    {
        gameObject.transform.position = targetPos.position;
    }

}
