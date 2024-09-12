using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    
    int coin;

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter2D(Collider other)
    {
        if (other.tag == "coins")
        {
            GameObject objectToDisappear = GameObject.Find("coins");
            coin = coin + 1;
            print("I have" + coin + "coins");
        }
    }


}