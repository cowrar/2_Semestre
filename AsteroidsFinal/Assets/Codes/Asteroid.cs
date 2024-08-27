using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int score = 0;

    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnParticleCollision(GameObject other)
    {
      Destroy(gameObject);
    }
}
