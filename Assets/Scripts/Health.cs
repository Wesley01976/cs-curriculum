using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using Random = UnityEngine.Random;


public class Health : MonoBehaviour

{
    // Start is called before the first frame update
    public GameManager gm;
    public bool canattack;
    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            gm.changeHealth(-1);
        }
    }

 
    // Update is called once per frame
}
