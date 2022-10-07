using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    public float speed;

   
    void FixedUpdate()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        if (transform.position.y>6.2f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("asteroid"))
        {
            Debug.Log("degdim");
            Destroy(collision.gameObject);
            mobilkontrol.instance.asteroidPatlama.Play();
        }
        
    }


}
