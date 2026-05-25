using UnityEngine;

public class Item : MonoBehaviour
{

    public ScriptableItem item;
    public Sprite itemSprite;

    private BoxCollider2D _bc2D;

    void Awake()
    {
        _bc2D = GetComponent<BoxCollider2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.transform.CompareTag("Player"))
        {
            InventoryManager.Instance.AddItem(item);
            Destroy(gameObject);
        }
    }
}
