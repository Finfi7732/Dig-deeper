using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private float _horizontal;
    private float _speed = 8f;
    private float _jump = 8f;
    private bool _facingRight = true;
    public GameObject dirt;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask dirtLayer;

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && (IsGrounded() || IsOnDirt()))
        {
            rb.velocity = new Vector2(rb.velocity.x, _jump);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (Input.GetButtonDown("Fire1") && IsOnDirt())
        {
            Destroy(dirt);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(_horizontal * _speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private bool IsOnDirt()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, dirtLayer);
    }

    private void Flip()
    {
        if (_facingRight && _horizontal < 0f || !_facingRight && _horizontal > 0f)
        {
            _facingRight = !_facingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
