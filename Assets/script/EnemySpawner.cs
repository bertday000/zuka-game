using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject enemyprefab;
    [SerializeField] float initialSpawnRate = 5f;
    float spawnrate;

    void Start()
    {
        spawnrate = initialSpawnRate;
    }

    
    void Update()
    {
        spawnrate -= Time.deltaTime;

        if (spawnrate <= 0) 
        {
            Instantiate(enemyprefab,transform.position, transform.rotation);
            spawnrate = initialSpawnRate;
        }
    }
}
