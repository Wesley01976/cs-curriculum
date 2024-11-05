using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Attackenemy : MonoBehaviour
{
    public GameObject Axe;
    public bool attacking = false;

    // Update is called once per frame
    void Update()
    {
        attacking = Input.GetMouseButton(0);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && attacking)
        {
            Destroy(other.gameObject);
            Instantiate(Axe, transform.position, quaternion.identity);
        }
    }
}
