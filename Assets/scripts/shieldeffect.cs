using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldeffect : MonoBehaviour
{
    public AudioSource asteroidPatlama;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("asteroid"))
        {
            Destroy(collision.gameObject);
            asteroidPatlama.Play();
            
        }
    }
}
