using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private bool isGrounded;
    private bool death;
    private Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            isGrounded = true;
        }if (collision.CompareTag("Respawn") || Mathf.Abs(rb.velocity.x) < 10f)
        {
            death = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            isGrounded = false;
        }if (collision.CompareTag("Respawn"))
        {
            death = false;
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (death)
        {
            transform.position = new Vector2(-33.91f, -2.53f);
            death = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Mouvement horizontal
        float horizontalMouvement = 2;
        Vector2 movement = new Vector2(horizontalMouvement * speed, rb.velocity.y);
        rb.velocity = movement;
    }
}
