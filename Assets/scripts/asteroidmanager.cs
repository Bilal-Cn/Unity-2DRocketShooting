using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidmanager : MonoBehaviour
{
    public GameObject[] prefabs;

    public float delay;

    public float maxX;
    public float minX;

    Coroutine coroutine;



    GameObject g;
    mobilkontrol mbk;


    public float gittikceHizlan = 0;






    public void BeginGenerator()
    {
        coroutine = StartCoroutine(Begin());

        g = GameObject.FindGameObjectWithTag("rocket");

        mbk = g.GetComponent<mobilkontrol>();

    }

    public void StopGeneration()
    {
        if (coroutine!=null)
        {
            StopCoroutine(coroutine);
        }
    }

    IEnumerator Begin()
    {
        while (true)
        {
            Instantiate(prefabs[Random.Range(0, prefabs.Length)],new Vector3(Random.Range(minX, maxX), transform.position.y),transform.rotation);
            yield return new WaitForSeconds(delay);


            gittikceHizlan += 0.01f;

            mbk.scrollSpeed += gittikceHizlan;
        }
    }
}
