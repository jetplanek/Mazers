using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementReal : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public Vector2 moveInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    moveInput.x = Input.GetAxisRaw("Horizontal");
    moveInput.y = Input.GetAxisRaw("Vertical");

    moveInput.Normalize();

    rb.velocity = moveInput * moveSpeed;
    }
}