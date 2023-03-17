using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigBod;

    [SerializeField]
    private string _horizontalInputName;

    [SerializeField]
    private KeyCode _jumpKey = KeyCode.Space;

    [SerializeField]
    private LayerMask m_GroundLayer;

    [SerializeField]
    private float m_JumpForce;

    [SerializeField]
    private float m_MoveSpeed;

    private float _movement;
    private bool _isJump;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        _rigBod = GetComponent<Rigidbody2D>();
         spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
   void Update()
{
    _movement = Input.GetAxis(_horizontalInputName);

    if (Physics2D.Raycast(transform.position, Vector2.down, 1f, m_GroundLayer))
    {
        if (Input.GetKeyDown(_jumpKey))
        {
            _isJump = true;
        }
    }

    if (_movement > 0) {
        spriteRenderer.flipX = true;
    }
    // Sinon, ne pas retourner le sprite
    else {
        spriteRenderer.flipX = false;
    }
}
    private void FixedUpdate()
    {
        if (_isJump)
        {
            _isJump = false;

            _rigBod.AddForce(Vector2.up * m_JumpForce, ForceMode2D.Impulse);
        }

        _rigBod.velocity = new Vector2(m_MoveSpeed * _movement, _rigBod.velocity.y);
    }

    public void Stop()
    {
        _rigBod.velocity = new Vector2(0, _rigBod.velocity.y);
        enabled = false;
    }
}
