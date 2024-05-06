using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int life;

    private void Update()
    {
        GameOver();
    }

    void GameOver()
    {
        if(life == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("BulletEnemy"))
        {
            life -= collision.gameObject.GetComponent<Damage>().damage;
        }
    }


}
