using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public bool canSpawn;

    public GameObject[] spawner;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawner.Length; i++)
        {
            spawner[i].SetActive(false);
        }
        
        if (canSpawn)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        if (Random.Range(0, 4) == 0)
        {
            spawner[0].SetActive(true);
            return;
        }

        if (Random.Range(0, 20) == 0)
        {
            spawner[1].SetActive(true);
            return;
        }
        
        if (Random.Range(0, 20) == 0)
        {
            spawner[2].SetActive(true);
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}