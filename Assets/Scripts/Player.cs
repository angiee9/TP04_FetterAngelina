
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float JumpForce;
    [SerializeField] bool onGround = false;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround == true)
            {
                rb.AddForce(Vector2.up * JumpForce);
                onGround = false;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if (onGround == false)
            {
                onGround = true;
            }
        }
    }
}
