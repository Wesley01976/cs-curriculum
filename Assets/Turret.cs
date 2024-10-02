using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour

{
    private int player;
    private int distance;
    private float cooldown;
    private int projectile;
    private float firerate;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject clone = Instantiate(b)
            
        }
    }
}
