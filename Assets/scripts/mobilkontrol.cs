using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilkontrol : MonoBehaviour
{
    public asteroidmanager asteroidmanager;

    public SkillManager skillmanager;

    public AudioSource coinAdd;
    public AudioSource skillAdd;
    public AudioSource rocketPatlama;
    public AudioSource asteroidPatlama;
    

    public static mobilkontrol instance;

    public GameObject gameOverScreen;

    private Vector3 touchPosition;
    private Vector3 direction;

    public Rigidbody2D[] brokenPieces;
    private Rigidbody2D rb;


    public float astreoidSpeed;
    private float moveSpeed = 10f;
    public float scrollSpeed = 0.05f;
    public float boostSpeed = 3f;


    public bool isAlive = true;

    public GameObject mainObject;
    public GameObject brokenObject;
    public GameObject boostEffect;
    public GameObject boost;
    public GameObject patlamaEffecti;
    public GameObject coin;
    public GameObject lazerGun;
    public GameObject shield;







    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        instance = this;
        asteroidmanager.BeginGenerator();
        scrollSpeed = 0.2f;
        moveSpeed = 0.005f;
        //astreoidSpeed = 0.20f;
        skillmanager.BeginGenerator();
    }


    void Update()
    {
        if (transform.position.x >= 2.21f)
        {
            transform.position = new Vector2(2.21f, transform.position.y);
        }
        if (transform.position.x <= -2.21f)
        {
            transform.position = new Vector2(-2.21f, transform.position.y);
        }
        if (transform.position.y >= 3.8f)
        {
            transform.position = new Vector2(transform.position.x, 3.8f);
        }
        if (transform.position.y <= -3.8f)
        {
            transform.position = new Vector2(transform.position.x, -3.8f);
        }

       

        astreoidSpeed += 0.00001f;
        scrollSpeed += 0.00001f;
        
       
        Touch touch;
       
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + touch.deltaPosition.x * moveSpeed, transform.position.y + touch.deltaPosition.y * moveSpeed);

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("asteroid"))
        {
            rocketPatlama.Play();
            Debug.Log("GameOver");
            isAlive = false;
            GameObject.Find("Score/ScoreText").GetComponent<score>().topla();
            mainObject.SetActive(false);
            brokenObject.SetActive(true);
            brokenObject.transform.position = new Vector3(mainObject.transform.position.x, mainObject.transform.position.y, -3.58f);
            gameOverScreen.SetActive(true);
            patlamaEffecti.SetActive(true);

            

            scrollSpeed = 0.05f;
            astreoidSpeed = 0.05f;
        }
        if (collision.gameObject.tag == ("coin"))
        {
            Destroy(collision.gameObject);
            score.instance.scoreValue += 1;
            coinAdd.Play();
        }
        if (collision.gameObject.tag == ("lazergun"))
        {
            
            Destroy(collision.gameObject);
            lazerGun.SetActive(true);
            StartCoroutine(LazerGunWait());
            lazerspawn.instance.stopSpawning = false;
            StartCoroutine(lazerspawn.instance.LazerSpawn());
            skillAdd.Play();

        }
        if (collision.gameObject.tag == ("boost"))
        {
            
            Destroy(collision.gameObject);
            astreoidSpeed = 0.50f;
            //scrollSpeed = 5f;
            StartCoroutine(BoostWait());
            skillAdd.Play();
        }
        if (collision.gameObject.tag == ("shield"))
        {
            
            Destroy(collision.gameObject);
            shield.SetActive(true);
            StartCoroutine(ShieldWait());
            skillAdd.Play();

        }

    }

    IEnumerator LazerGunWait()
    {
        yield return new WaitForSeconds(10);
        lazerGun.SetActive(false);
        lazerspawn.instance.stopSpawning = true;
    }

    IEnumerator ShieldWait()
    {
        yield return new WaitForSeconds(10);
        shield.SetActive(false);
    }
    IEnumerator BoostWait()
    {
        yield return new WaitForSeconds(10);
        //scrollSpeed = 0.9f;
        astreoidSpeed = 0.08f;
    }

}
