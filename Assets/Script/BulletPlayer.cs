using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    [Header("Bullet")]
    private Rigidbody rb;
    public float speed;
    private Vector3 direction;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    public void SetDirection(Vector4 direction)
    {
        this.direction = direction;
    }

    void Update()
    {
        rb.velocity = direction * speed;
        Destroy(gameObject, 3f);
        
    }
}
