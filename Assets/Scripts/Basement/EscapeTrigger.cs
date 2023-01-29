using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTrigger : MonoBehaviour
{
    public GameObject Candle1;
    public GameObject Candle2;
    public GameObject Candle3;
    public GameObject Candle4;
    public GameObject Candle5;

    public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        exit.SetActive(false);
        

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (Candle1.gameObject.active == true)
        {
            exit.SetActive(true);
        }
        
       /* if (col.CompareTag("Player"))
        {
            exit.SetActive(true);
        } */
    }
}
