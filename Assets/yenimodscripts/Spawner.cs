using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public mobilkontrol2 Rocket;

    public GameObject asteroidKusagi;

    public float height;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (!Rocket.isDead)
        {            
            Instantiate(asteroidKusagi, new Vector3(3, Random.Range(-height, height),-8.74f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
       
    }
}
