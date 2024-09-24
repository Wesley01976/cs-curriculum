using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public int coins;
    public static GameManager gm;
    private int health;
    private int max_health = 10;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HealthText;

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    
    void Start()
    {
        
        CoinText.text = "Coins: " + coins.ToString();
    }

    public void AM_Coins() 
    {
        coins += 1;
        CoinText.text = "Coins: " + coins;
        
    }

// Update is called once per frame
    void Update()
    {
    
    }

    int gethealth()
    {
        return health;
    }

    public void changeHealth(int amount)
    {
        health += amount;
        if (health > max_health)
        {
            health = max_health;
        }

        if (health < 1)
        {
            print("You Died!");
        }
    }


      
}
    // Start is called before the first frame update



