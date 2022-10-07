using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundscontrol : MonoBehaviour
{

    public soundscontrol instance;

    public AudioSource[] soundsEffect;
    void Start()
    {
        instance = this;
        soundsEffect = GetComponent<AudioSource[]>();
    }

  
   
}
