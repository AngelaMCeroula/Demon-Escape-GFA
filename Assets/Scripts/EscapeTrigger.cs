using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTrigger : MonoBehaviour
{
    public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        exit.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            exit.SetActive(true);
        }
    }
}
