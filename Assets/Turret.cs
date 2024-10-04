using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Turret : MonoBehaviour

{
    private int player;
    private int distance;
    private float cooldown = 1;
    private int projectile;
    private float firerate = 2;
    public GameObject bulletprefab;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject clone = Instantiate(bulletprefab, transform.position, quaternion.identity);
            Bullet script = clone.GetComponent<Bullet>();
            script.targetPos = other.gameObject.transform.position;
            cooldown = firerate;
        }
    }

    private void Update()
    {
        cooldown -= Time.deltaTime;
    }
}
