using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class Monster_Energy : MonoBehaviour
{

    public GameManager gm;

    private void Update()
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Monster Energy"))
            {
                Object.Destroy(gameObject);
                print("I AM SPEED!!!!!!!");
                gm.hasMonsterEnergy = true;
            }
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
    }
}