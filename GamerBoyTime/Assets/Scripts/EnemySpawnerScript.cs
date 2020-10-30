using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public Vector2 whereToSpawn;
    Vector2 Spawn;
    float randX;
    float randY;
    public float SpawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            randX = Random.Range(-3.0f, 3.0f);
            randY = Random.Range(-3.0f, 3.0f);
            Spawn = new Vector2(randX, randY);
            Instantiate (enemy, Spawn, Quaternion.identity);
        }
    }
}
