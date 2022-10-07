using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanoynatma : MonoBehaviour
{
    

    GameObject g;
    mobilkontrol mbk;


    public Material[] materials;
    Renderer render;





    //public float speed;
    void Start()
    {
        //materials = GetComponent<MeshRenderer>().materials;


        g = GameObject.FindGameObjectWithTag("rocket");
        mbk = g.GetComponent<mobilkontrol>();


        render = GetComponent<Renderer>();
        render.enabled = true;
        //renderer.sharedMaterial = materials[0];










    }


    void Update()
    {
        if (mbk.scrollSpeed > 0.1)
        {
            //Debug.Log("sfdfasd");
            render.sharedMaterial = materials[0];
            //material = GetComponent<MeshRenderer>().material;
            materials[0].SetTextureOffset("_MainTex", materials[0].GetTextureOffset("_MainTex") + (Vector2.up * Time.deltaTime * mobilkontrol.instance.scrollSpeed));


        }

        if (mbk.scrollSpeed > 0.25)
        {
            //Debug.Log("sfdfasd");
            render.sharedMaterial = materials[1];
            //material = GetComponent<MeshRenderer>().material;
            materials[1].SetTextureOffset("_MainTex", materials[1].GetTextureOffset("_MainTex") + (Vector2.up * Time.deltaTime * mobilkontrol.instance.scrollSpeed));


        }
        if (mbk.scrollSpeed > 0.3)
        {
            //Debug.Log("sfdfasd");
            render.sharedMaterial = materials[2];
            materials[2].SetTextureOffset("_MainTex", materials[2].GetTextureOffset("_MainTex") + (Vector2.up * Time.deltaTime * mobilkontrol.instance.scrollSpeed));

            //material = GetComponent<MeshRenderer>().material;

        }

       // materials[1].SetTextureOffset("_MainTex", materials[1].GetTextureOffset("_MainTex") +(Vector2.up* Time.deltaTime * mobilkontrol.instance.scrollSpeed));
   
    
    }









}
