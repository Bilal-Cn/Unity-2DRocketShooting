using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremainmenu : MonoBehaviour
{
    score score;

    public int totalCoin;
    Text scoreText;

    public static scoremainmenu instance;

    void Start()
    {
        instance = this;
        scoreText = GetComponent<Text>();
        totalCoin = PlayerPrefs.GetInt("totalCoin");
    }

    private void FixedUpdate()
    {
        scoreText.text = totalCoin + "";
      
    }

   

}
