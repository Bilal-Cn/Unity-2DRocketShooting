using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public float shieldSpeed;
    void Update()
    {

        transform.position += new Vector3(0, -shieldSpeed, 0);
        transform.Rotate(new Vector3(0f, 0f, 45 * Time.deltaTime));
        shieldSpeed += 0.00001f;

        if (gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("asteroid"))
        {
            Destroy(collision.gameObject);
           
        }
    }
}
