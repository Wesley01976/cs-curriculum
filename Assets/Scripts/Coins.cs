using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Object.Destroy(other.gameObject);
            gm.AM_Coins();
            print("I have " + gm.coins + " coins!");
        }
        if (other.CompareTag("Spikes"))
        {
            Health -= 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
    }
    
    
    //
    void Update()
    {
        
    }


}
