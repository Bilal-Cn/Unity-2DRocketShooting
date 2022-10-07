using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float coinSpeed;


    void Update()
    {
        transform.position += new Vector3(0, -coinSpeed, 0);
        transform.Rotate(new Vector3(0f, 0f, 45 * Time.deltaTime));
        coinSpeed += 0.00001f;

        if (gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }



}
