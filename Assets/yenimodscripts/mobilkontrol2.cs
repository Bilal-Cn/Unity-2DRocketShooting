using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilkontrol2 : MonoBehaviour
{
    public static mobilkontrol2 instance;

    Rigidbody2D rb2d;

    public bool isDead;

    public float force = 1f;
    public float scrollSpeed = 3f;

    public GameObject main;
    public GameObject broken;
    public GameObject gameOver;




    void Start()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
        scrollSpeed = 3f;
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {

                rb2d.velocity = Vector2.up * force;
                //rb2d.AddForce(Vector3.up * force);
            }
        }
        if (main.transform.position.y < -8)
        {
            gameOver.SetActive(true);
            Debug.Log("gameover");
            main.SetActive(false);
            broken.SetActive(true);
            broken.transform.position = new Vector3(main.transform.position.x, main.transform.position.y, -12);
            scrollSpeed = 0.05f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("duvar") || collision.gameObject.tag == ("asteroid"))
        {
            gameOver.SetActive(true);
            Debug.Log("gameover");
            main.SetActive(false);
            broken.SetActive(true);
            broken.transform.position = new Vector3(main.transform.position.x, main.transform.position.y, -12);
            scrollSpeed = 0.05f;
        }
    }
}
