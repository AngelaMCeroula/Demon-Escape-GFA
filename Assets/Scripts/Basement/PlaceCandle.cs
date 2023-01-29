using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Inventory
{
    public class PlaceCandle : MonoBehaviour
    {
        private InventorySystem _iSsytem;
        public string itemRequiredName;
        public Sprite itemRequiredSprite;
        private Animator animator;
        public GameObject cCandle;


        private void Start()
        {
            _iSsytem = GameObject.Find("Player").GetComponent<InventorySystem>();
        }
        

        public void CheckItem()
        {

            if (_iSsytem.HasItem(itemRequiredName, itemRequiredSprite) == true)
            {
               
                CandlePlace();
                _iSsytem.RemoveItem(itemRequiredName,itemRequiredSprite);
                return;
            }

            if (_iSsytem.HasItem(itemRequiredName, itemRequiredSprite) == false)
            {
                Debug.Log(message:"Pls");
                return;
            }
        }
        
        private void CandlePlace()
        {
            Debug.Log("Candle Placed");
            cCandle.SetActive(true);

        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            CheckItem();            
        }
    }
}