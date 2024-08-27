using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public GameObject asteroidPreFab;
    public Vector3 asteroidpoint;

    public int maxX = 10;
    public int maxY = 10;
    public int  x = 0;
    public int  y = 0;
    public float timer;
    public float nextSpawn = 2f;

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
