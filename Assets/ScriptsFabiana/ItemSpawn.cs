using System.Collections;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    [SerializeField] GameObject Item;


    GameObject actualItem;
    float respawnTime;
    bool ItemDestroyed;

    bool CourrutineActive;


    private void Start()
    {
        GameObject spawnedItem = Instantiate(Item, transform.position, transform.rotation);
        spawnedItem.transform.SetParent(transform);
        actualItem = spawnedItem;
    }

    private void Update()
    {
        if (actualItem != null)
        {
            ItemDestroyed = false;
        }
        else
        {
            ItemDestroyed = true;
        }

        if(ItemDestroyed && !CourrutineActive)
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        CourrutineActive = true;

        respawnTime = Random.Range(1f, 4f);
        yield return new WaitForSeconds(respawnTime); 

        GameObject spawnedItem = Instantiate(Item, transform.position, transform.rotation);
        spawnedItem.transform.SetParent(transform);
        actualItem = spawnedItem;

        CourrutineActive = false;
    }
}
