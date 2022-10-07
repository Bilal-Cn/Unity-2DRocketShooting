using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public GameObject[] prefabs;

    public float delay;

    public float maxX;
    public float minX;

    Coroutine coroutine;

    public static SkillManager instance;

    private void Start()
    {
        instance = this;
    }
    public void BeginGenerator()
    {
        coroutine = StartCoroutine(Begin());
    }

    public void StopGeneration()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
    }

    IEnumerator Begin()
    {
        while (true)
        {
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(minX, maxX), transform.position.y), transform.rotation);
            yield return new WaitForSeconds(delay);
            Debug.Log("geliyor");
        }
    }
}
