using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class InventorySystem : MonoBehaviour
    {
        private List<string> _inventoryList = new List<string>();
        public List<GameObject> inventorySlots;

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
                if (slot.GetComponent<SpriteRenderer>().sprite == itemSprite)
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
                RemoveItem(itemName, itemSprite);
            }

            return _inventoryList.Contains(itemName);
        }
    } 
}    