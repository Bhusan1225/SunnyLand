using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class playerController : MonoBehaviour
{

    float HorizontalInput;
    float PlayerSpeed;

    Rigidbody2D rb;
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
        HorizontalInput = Input.GetAxisRaw("horizontal");
    }

    void playerMovement()
    {
        Vector2 newVelocity = new Vector2(HorizontalInput, 0).normalized;
        rb.velocity = newVelocity * PlayerSpeed; 
    }
}
