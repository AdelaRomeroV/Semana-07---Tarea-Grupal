using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Player : MonoBehaviour
{
    [Header("Disparo")]
    [SerializeField] private GameObject[] bullet;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private int CountBullet;//cantidad de balas que se pondra en el juego

    void Update()
    {
        ContadorBalas();        
    }

    void ContadorBalas()
    {
        if(CountBullet > 0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Disparo(0);
            }

            if(Input.GetMouseButtonDown(1))
            {
                Disparo(1);
            }
        }
    }
    
    void Disparo(int bulletType) //Cantidad de balas en el arreglo 
    {
        GameObject obj = Instantiate(bullet[bulletType]);//cantidad de balas asignada en el arreglo 
        obj.transform.position = shootPoint.position;
        obj.GetComponent<BulletPlayer>().SetDirection(shootPoint.forward);
        CountBullet--;
    }
    
}
