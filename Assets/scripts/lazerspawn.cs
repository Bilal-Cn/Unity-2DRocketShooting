using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerspawn : MonoBehaviour
{
    public static lazerspawn instance;

    public AudioSource lazerGun;

    public GameObject lazer;
    public GameObject spawner;
    public bool stopSpawning = false;

    

   void Start()
    {
        instance = this;
        StartCoroutine(LazerSpawn());

    }

    public IEnumerator LazerSpawn()
    {

        while (!stopSpawning)
        {
            Instantiate(lazer, new Vector2(spawner.transform.position.x, spawner.transform.position.y), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            lazerGun.Play();
            
        }


    }
}
