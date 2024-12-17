using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


public class GameManager : MonoBehaviour
{
    public int coins;
    public static GameManager gm;
    private int health;
    private int max_health = 10;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    public bool hasAxe;
    public bool hasMonsterEnergy;
    public bool MonsterEnergyDranken = false;
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
        health = max_health;
        healthText.text = "Health: " + health;
        coinText.text = "Coins: " + coins.ToString();
    }

    public void AM_Coins() 
    {
        coins += 1;
        coinText.text = "Coins: " + coins;
    }
    public void Change_Health(int hello) 
    {
        health += hello;
        healthText.text = "Health: " + health;
    }

// Update is called once per frame
    void Update()
    {
        if (gm.hasMonsterEnergy = true)
        {
            gm.MonsterEnergyDranken = Input.GetKeyDown(KeyCode.E);
        }

        if (gm.MonsterEnergyDranken = true)
        {
            gm.hasMonsterEnergy = false;
        }
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
            coins = 0;
            health = max_health;
            SceneManager.LoadScene("Start");
            Destroy(gameObject);
        }
       

        healthText.text = "Health: " + health;
    }


      
}
    // Start is called before the first frame update



