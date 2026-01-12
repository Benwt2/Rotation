using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    Rigidbody rb;
    Vector3 input;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 move = input.normalized * moveSpeed;
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }
}

