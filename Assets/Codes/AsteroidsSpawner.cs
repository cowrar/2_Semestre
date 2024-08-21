using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    public GameObject asteroidPreFab;
    public Vector3 asteroidpoint;
    public float timer;
    public float nextSpawn = 6.5f;
    public int maxX = 10;
    public int maxY = 10;
    int x = 0;
    int y = 0;

    void Start()
    {
        timer = 0;
        asteroidpoint.x = x;
        asteroidpoint.y = y;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if (timer >= nextSpawn)
        {
            x = Random.Range(-15, maxX);
            y = Random.Range(12, maxY);   
            asteroidpoint.x = x;
            asteroidpoint.y = y;
            GameObject asteroid = Instantiate(asteroidPreFab, asteroidpoint, Quaternion.identity);
            timer = 0;
        }
    }
}