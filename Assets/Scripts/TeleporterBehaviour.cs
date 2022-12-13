using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TeleporterBehaviour : MonoBehaviour
{
    public List<Vector3> roomLocations;

    public float delayInSeconds;

    private void Start()
    {
        StartCoroutine(Delay());
    }

    private Vector3 NewRoomLocation()
    {
        Vector3 _newRoomLocation;
        _newRoomLocation = roomLocations[Random.Range(0, roomLocations.Count)];
        return _newRoomLocation;
    }

    private void TeleportPathNode()
    {
        gameObject.transform.position = NewRoomLocation();
        Debug.Log(gameObject.transform.position);
    }
    
    private IEnumerator Delay()
    {
        TeleportPathNode();
        yield return new WaitForSeconds(delayInSeconds);
        StartCoroutine(Delay());
    }
}
