using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class Monster_Energy : MonoBehaviour
{

    public GameManager gm;
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
                gm.hasMonsterEnergy = true;
            }
        }

        private void Update()
        {
            print("Have:"+gm.hasMonsterEnergy);
            print("Drank:"+gm.MonsterEnergyDranken);
        }


        // Start is called before the first frame update
    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
        gm.hasMonsterEnergy = false;
    }
}