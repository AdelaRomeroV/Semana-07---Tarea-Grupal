using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangeA : MonoBehaviour
{
    public GameObject prefab;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        Invoke("Disparo", 5f);
    }

    void Disparo()
    {
        if(player != null)
        {
            Instantiate(prefab, gameObject.transform);
        }
    }
}
