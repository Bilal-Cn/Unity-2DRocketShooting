using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaPlanDegis : MonoBehaviour
{

    GameObject g;
    mobilkontrol mbk;


    public Material[] material;

    Material materialss;

    Renderer render;


    // Start is called before the first frame update
    void Start()
    {
        g = GameObject.FindGameObjectWithTag("rocket");
        mbk = g.GetComponent<mobilkontrol>();


        render = GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = material[0];


        materialss = GetComponent<MeshRenderer>().material;



    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(mbk.scrollSpeed);


        if (mbk.scrollSpeed > 0.25)
        {
            //Debug.Log("sfdfasd");
            render.sharedMaterial = material[1];
            materialss = GetComponent<MeshRenderer>().material;

        }
        if (mbk.scrollSpeed > 0.3)
        {
            //Debug.Log("sfdfasd");
            render.sharedMaterial = material[2];
            materialss = GetComponent<MeshRenderer>().material;

        }

    }
}
