using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            transform.forward = new Vector3(horizontal, 0, vertical);
        }

        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
    }
}
