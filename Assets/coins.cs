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
            gm.coins += 1;
            print("I have " + gm.coins + " coins!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    
    
    //
    void Update()
    {
        
    }


}
