using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    public int speed = 5;

    void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        _rb2D.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, _rb2D.linearVelocity.y);
    }
}
