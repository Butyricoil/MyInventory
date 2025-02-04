using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class InventoryManager : MonoBehaviour
    {
        public GameObject InventoryMenu;
        private bool menuActivated;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                menuActivated = !menuActivated;
                InventoryMenu.SetActive(menuActivated);
            }
        }


        public AddItem(string itemName, int quantity, Sprite itemSprite)
        {
            Debug.Log("itemNmae = " + itemName + "quantity = " +
                           quantity + "itemSprite" +  itemSprite);
        }
    }
}
