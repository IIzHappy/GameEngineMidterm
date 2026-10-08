using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    BoxCollider2D _boxCollider;

    [SerializeField] float _moveSpeed = 8;
    [SerializeField] float _jumpHeight = 12;

    [SerializeField] LayerMask _standOnLayer;

    public KeyCode _left = KeyCode.A;
    public KeyCode _right = KeyCode.D;
    public KeyCode _jump = KeyCode.W;
    public KeyCode _shoot = KeyCode.S;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(_shoot)) Shoot();
    }

    void Move()
    {
        float horMove = 0;
        if (Input.GetKey(_left)) horMove--;
        if (Input.GetKey(_right)) horMove++;
        _rb.linearVelocityX = horMove * _moveSpeed;

        if (Input.GetKeyDown(_jump))
        {
            if (IsGrounded())
            {
                _rb.AddForce(Vector2.up * _jumpHeight, ForceMode2D.Impulse);
            }
        }
    }

    private bool IsGrounded()
    {
        float extraHeight = 0.05f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, extraHeight, _standOnLayer);
        return raycastHit.collider != null;
    }

    void Shoot()
    {

    }
}
