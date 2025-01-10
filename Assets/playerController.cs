using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float HorizontalInput;
    public float VerticalInput;
    public float PlayerSpeed;


    

    //jump
    public float jumpHeight = 10f;
    public float groundCheckDistance = 1f;
    public LayerMask groundLayer;
    public GameObject checkGround;
    Rigidbody2D rb;
    private bool isGrounded;


    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        playerMovement();
        jump();
    }

    void PlayerInput()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void playerMovement()
    {
        //Vector2 newVelocity = new Vector2(HorizontalInput, 0).normalized;
        //rb.velocity = newVelocity * PlayerSpeed;

        Vector2 position = transform.position;
        position.x += HorizontalInput * PlayerSpeed * Time.deltaTime;
        transform.position = position;

        animator.SetFloat("Walk", Mathf.Abs(HorizontalInput));

        Vector3 scale = transform.lossyScale;

        if (HorizontalInput > 0)
        {
            scale.x = Mathf.Abs(scale.x);

        }
        else 
        {
            scale.x = -1f * Mathf.Abs(scale.x);

        }
        transform.localScale = scale;
    }


    void jump()
    {
        isGrounded = Physics2D.Raycast(checkGround.transform.position, Vector2.down, groundCheckDistance, groundLayer);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            startJump();
        }
    }

    void startJump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(checkGround.transform.position, transform.position + Vector3.down * groundCheckDistance);
    }
}
