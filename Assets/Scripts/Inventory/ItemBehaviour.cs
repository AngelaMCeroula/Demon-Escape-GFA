using Unity.VisualScripting;
using UnityEngine;

namespace Inventory
{
    public class ItemBehaviour : MonoBehaviour
    {
        public Sprite itemImage;
        public string itemName;
    
        private SpriteRenderer spriteR;
        private InventorySystem inventorySystem;

        void Awake()
        {
            spriteR = GetComponent<SpriteRenderer>();
            inventorySystem = GameObject.Find("Player").GetComponent<InventorySystem>();
            SetSprite();
        }
    
        void SetSprite()
        {
            spriteR.sprite = itemImage;
        }

        void AddItem()
        {
            inventorySystem.AddItem(itemName, itemImage);
        }
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GameObject().name == "Player")
            {
                AddItem();
                Destroy(gameObject);
            }
        }
    }
}
