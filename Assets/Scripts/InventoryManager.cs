using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public ScriptableItem[] items;
    public Text[] itemsText;
    public Image[] itemsImage;
    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = item;
                itemsText[i].text = item.itemName.ToString();
                itemsImage[i].sprite = item.itemSprite;
                return;
            }
        }
    }
}
