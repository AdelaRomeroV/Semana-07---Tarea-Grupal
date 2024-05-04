using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    private GameObject playerlife;

    private void Start()
    {
        playerlife = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerlife.GetComponent<PlayerLife>().life++;
            Destroy(gameObject);
        }

    }
}
