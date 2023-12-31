using UnityEngine;

public class BasicMovementReal : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 moveInput;

    // Adjust these variables for each player
    public string horizontalInputAxis;
    public string verticalInputAxis;

    // Each player needs its own Rigidbody2D
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component for each player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Use the input axes specific to each player
        moveInput.x = Input.GetAxisRaw(horizontalInputAxis);
        moveInput.y = Input.GetAxisRaw(verticalInputAxis);

        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
    }
}