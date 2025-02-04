using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemSlot : MonoBehaviour
{
    //=====Item data======//
    public string itemName;
    public int quantity;
    public Sprite itemSprite;
    public bool isFull;



    //=======ItemSlot=====//
    [SerializeField]   // makes this variable visible and editable in the Unity Inspector
    private TMP_Text quantityText;

    [SerializeField]
    private Image itemImage;

    public void AddItem (string itemName, int quantity, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.quantity = quantity;
        this.itemSprite = itemSprite;
        isFull = true;

        quantityText.text = quantity.ToString();
        quantityText.enabled = true;
        itemImage.sprite = itemSprite;
    }




}
