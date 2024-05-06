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
}
