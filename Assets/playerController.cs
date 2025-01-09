using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float HorizontalInput;
    public float PlayerSpeed;

    Rigidbody2D rb;



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
    }

    void PlayerInput()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void playerMovement()
    {
        Vector2 newVelocity = new Vector2(HorizontalInput, 0).normalized;
        rb.velocity = newVelocity * PlayerSpeed;

        animator.SetFloat("Walk", Mathf.Abs(HorizontalInput));
    }


}
