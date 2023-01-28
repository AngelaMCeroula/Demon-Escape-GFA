using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class InventorySystem : MonoBehaviour
    {
        private List<string> _inventoryList = new List<string>();
        public List<GameObject> inventorySlots;
        private bool hasItem;

        public void AddItem(string item, Sprite itemSprite)
        {
            _inventoryList.Add(item);

            foreach (GameObject slot in inventorySlots)
            {
                if (slot.activeSelf == false)
                {
                    slot.SetActive(true);
                    slot.GetComponent<Image>().sprite = itemSprite;
                    break;
                }
            }
        }

        public void RemoveItem(string itemName, Sprite itemSprite)
        {
            _inventoryList.Remove(itemName);
            foreach (GameObject slot in inventorySlots)
            {
                var slotImage = slot.GetComponent<Image>();
                
                if (slotImage.sprite == itemSprite)
                {
                    slot.SetActive(false);
                    break;
                }
            }
        }

        public bool HasItem(string itemName, Sprite itemSprite)
        {

            if (_inventoryList.Contains(itemName))
            {
                hasItem = true;
            }

            if (!_inventoryList.Contains(itemName))
            {
                hasItem = false;
            }

            return hasItem;
        }
    } 
}    