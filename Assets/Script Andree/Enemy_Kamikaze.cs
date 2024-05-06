using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Kamikaze : MonoBehaviour
{
    [SerializeField] Transform Player;

    Rigidbody rgb;


    private void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Transform>();
        rgb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 vel = new Vector3(Player.position.x - transform.position.x, 0, Player.position.z - transform.position.z);
        rgb.velocity = vel.normalized * 320 * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
