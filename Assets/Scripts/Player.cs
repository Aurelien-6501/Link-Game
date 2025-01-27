using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 _movement;
    private Rigidbody2D _rigidbody2D;
    public float speed = 5f;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Debug.Log("Start Player");
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        _movement = new Vector2(horizontal, vertical);
    }

    void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = _movement * speed;
    }
}
