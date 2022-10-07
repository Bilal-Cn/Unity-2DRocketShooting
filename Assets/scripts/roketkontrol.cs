using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketkontrol : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float kalkisSpeed;
    public float yonSpeed;
    public GameObject benzin;
    public GameObject buton;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        LeftRight(horizontal);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "benzin")
        {
            kalkisSpeed += 500f;
            Destroy(benzin);
        }
    }

    
    public void Firlatma()
    {

        rigidBody.AddForce(transform.up * kalkisSpeed);
        buton.SetActive(false);
    }

    public void LeftRight(float horizontal)
    {
        rigidBody.velocity = new Vector2(horizontal * yonSpeed, rigidBody.velocity.y);
    }
}
