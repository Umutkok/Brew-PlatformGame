using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float runSpeed;
    public Animator animator;
    float horizontalMove;
    
    [SerializeField] private bool facingRight = true;

    public float jump;

    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(runSpeed * horizontalMove, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
      
        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (horizontalMove<0 && facingRight)
        {
            FlipWithRotation();
        }
        else if (horizontalMove > 0 && !facingRight)
        {
            FlipWithRotation();
        }


         void FlipWithRotation()
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }

        //animator içine y velocity sini koymak için
        animator.SetFloat("yVelocity", rb.velocity.y);

        if(rb.velocity.y < -0.1)
        {
            animator.SetBool("isJumping", true);
        }


    }

    public bool isGrounded()
    {
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistance, groundLayer))
        {
            
            return true;
            
        }
        else
        {
           
            return false;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            animator.SetBool("isJumping", false);
        }
    }



    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireCube(transform.position - transform.up * castDistance, boxSize);
    //}


}
