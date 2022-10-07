using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int scoreValue;
    Text ScoreText;
    public int totalCoin;
    public static score instance;



    void Start()
    {
        totalCoin = PlayerPrefs.GetInt("totalCoin");
        ScoreText = GetComponent<Text>();
        instance = this;
        
    }

    
    void FixedUpdate()
    {
        ScoreText.text = ""+ scoreValue;
        //ScoreText.text += scoreValue;
    }

    public void topla()
    {
        totalCoin += scoreValue;
        PlayerPrefs.SetInt("totalCoin", totalCoin);
    }
}
