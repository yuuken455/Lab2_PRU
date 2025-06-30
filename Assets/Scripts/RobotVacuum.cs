using UnityEngine;

public class RobotVacuum : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Lấy đầu vào từ bàn phím
        float moveX = Input.GetAxisRaw("Horizontal"); // A, D
        float moveY = Input.GetAxisRaw("Vertical");   // W, S

        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        Vector2 newPos = rb.position + moveDirection * moveSpeed * Time.deltaTime;
        rb.MovePosition(newPos);
    }
}
