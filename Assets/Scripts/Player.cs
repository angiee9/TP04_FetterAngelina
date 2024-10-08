using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float JumpForce;
    [SerializeField] bool onGround = false;

    AudioManager audioManager;

    private Animator playerAnimator;
    private AudioSource jumpSound;
    

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        jumpSound = GetComponent<AudioSource>();
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
    }

  
    void Update()
    {
        playerAnimator.SetBool("isGrounded", onGround);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround == true)
            {
                rb.AddForce(Vector2.up * JumpForce);
                jumpSound.Play();
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

       

        if (collision.gameObject.CompareTag("obstacle"))
        {
            GameManager.Instance.ShowGameOverScreen();
            playerAnimator.SetTrigger("die");
            audioManager.PlaySFX(audioManager.death);
            Time.timeScale = 0;
            
        }

    }
}
