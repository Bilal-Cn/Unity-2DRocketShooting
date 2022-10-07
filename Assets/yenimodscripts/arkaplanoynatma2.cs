using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanoynatma2 : MonoBehaviour
{
    Material material;

    
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }


    void Update()
    {
        material.SetTextureOffset("_MainTex", material.GetTextureOffset("_MainTex") + (Vector2.up * Time.deltaTime * mobilkontrol2.instance.scrollSpeed));
    }
}
