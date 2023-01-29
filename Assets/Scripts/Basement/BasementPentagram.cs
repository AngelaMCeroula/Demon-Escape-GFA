using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    public class BasementPentagram : MonoBehaviour
    {
        private InventorySystem _iSsytem;
        public string itemRequiredName1;
        public string itemRequiredName2;
        public string itemRequiredName3;
        public string itemRequiredName4;
        public string itemRequiredName5;
        public Sprite itemRequiredSprite;
        private Animator animator;

        private bool _candle1Placed = false;
        private bool _candle2Placed = false;
        private bool _candle3Placed = false;
        private bool _candle4Placed = false;
        private bool _candle5Placed = false;
        private bool _allCandlesPlaced = false;
        

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

            if (_iSsytem.HasItem(itemRequiredName1, itemRequiredSprite) == true)
            {
                _candle1Placed = true;
                _iSsytem.RemoveItem(itemRequiredName1,itemRequiredSprite);
                return;
            }

            if (_iSsytem.HasItem(itemRequiredName1, itemRequiredSprite) == false)
            {
                Debug.Log(message:"Pls");
                return;
            }
            
            if (_iSsytem.HasItem(itemRequiredName2, itemRequiredSprite) == true)
            {
                _candle2Placed = true;
                _iSsytem.RemoveItem(itemRequiredName2,itemRequiredSprite);
                return;
            }
            if (_iSsytem.HasItem(itemRequiredName3, itemRequiredSprite) == true)
            {
                _candle3Placed = true;
                _iSsytem.RemoveItem(itemRequiredName3,itemRequiredSprite);
                return;
            }
            if (_iSsytem.HasItem(itemRequiredName4, itemRequiredSprite) == true)
            {
                _candle4Placed = true;
                _iSsytem.RemoveItem(itemRequiredName4,itemRequiredSprite);
                return;
            }
            
            if (_iSsytem.HasItem(itemRequiredName5, itemRequiredSprite) == true)
            {
                _candle5Placed = true;
                _iSsytem.RemoveItem(itemRequiredName5,itemRequiredSprite);
                return;
            }

            if (_candle1Placed == true && _candle2Placed == true && _candle3Placed == true && _candle5Placed == true && _candle5Placed == true)
            {
                _allCandlesPlaced = true;

            }
            
            
        }
      
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            CheckItem();            
        }
    }
}