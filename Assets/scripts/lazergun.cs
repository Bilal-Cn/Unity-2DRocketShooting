using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazergun : MonoBehaviour
{
    public float lazerGunSpeed;


    void Update()
    {
        transform.position += new Vector3(0, -lazerGunSpeed, 0);
        transform.Rotate(new Vector3(0f, 0f, 45 * Time.deltaTime));


        if (gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
