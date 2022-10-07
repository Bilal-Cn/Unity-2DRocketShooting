using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class roket : MonoBehaviour
{
    public static roket instance;

    public Rigidbody2D rb;
    public PolygonCollider2D collide;
    public float scrollSpeed;
    public float speedX;
    public float speedY;
    void Start()
    {
        instance = this;

        rb = GetComponent<Rigidbody2D>();
        collide = GetComponent<PolygonCollider2D>();



    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(transform.position.x, speedY * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        MovementHorizontal(horizontal);
        float vertical = Input.GetAxis("Vertical");
        MovementVertical(vertical);
        //if (Input.touchCount > 0)
        //{
        //    Touch parmak = Input.GetTouch(0);
        //    if (parmak.phase == TouchPhase.Began)
        //    {
        //        Debug.Log("dokundu");
        //        rb.velocity = new Vector2(0, -3.1f);
        //    }
        //    if (parmak.phase == TouchPhase.Stationary)
        //    {
        //        Debug.Log("dokunuyorum");
        //    }
        //    if (parmak.phase == TouchPhase.Moved)
        //    {
        //        Debug.Log("sürükleniyor");
        //    }
        //    if (parmak.phase == TouchPhase.Ended)
        //    {
        //        Debug.Log("dokunmabitti");
        //    }

        //}

    }

    void MovementHorizontal(float horizontal)
    {
        rb.velocity = new Vector2(horizontal * speedX, rb.velocity.y);
    }

    void MovementVertical(float vertical)
    {
        rb.velocity = new Vector2(rb.velocity.x, vertical * speedY);
    }
}
