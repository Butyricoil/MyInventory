using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Intem : MonoBehaviour
    {
        [SerializeField]
        private string itemName;
        [SerializeField]
        private int quantity;
        [SerializeField]
        private Sprite sprite;
        private InventoryManager inventoryManager

        // Use this for initialization
        void Start()
        {
           inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                inventoryManager.AddItem(itemName, quantity, sprite);
                Destroy(gameObject);
            }
        }
    }
}