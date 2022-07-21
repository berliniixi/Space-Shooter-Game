using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;

    private float randX;

    private Vector2 WhereToSpawn;

    public float spawnRate = 2f;

    private float nextSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            WhereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, WhereToSpawn, Quaternion.identity);
        }
    }
}
