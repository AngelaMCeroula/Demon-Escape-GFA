using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Inventory
{
    public class BarricadeScript : MonoBehaviour
    {
        private InventorySystem _iSsytem;
        public string itemRequiredName;
        public Sprite itemRequiredSprite;
        private Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        private void Start()
        {
            _iSsytem = GameObject.Find("Player").GetComponent<InventorySystem>();
        }
        

        public void CheckItem()
        {

            if (_iSsytem.HasItem(itemRequiredName, itemRequiredSprite) == true)
            {
               
                OpenDoor();
                _iSsytem.RemoveItem(itemRequiredName,itemRequiredSprite);
                return;
            }

            if (_iSsytem.HasItem(itemRequiredName, itemRequiredSprite) == false)
            {
                Debug.Log(message:"Pls");
                return;
            }
        }
        
        private void OpenDoor()
        {
            Debug.Log("OPEEEEEEEEEN");
            Destroy(gameObject);

        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            CheckItem();            
        }
    }
}