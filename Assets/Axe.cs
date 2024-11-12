using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public GameManager gm;
    private TopDown_AnimatorController animatorController;
    private void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
        animatorController = FindFirstObjectByType<TopDown_AnimatorController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.hasAxe = true;
            other.GetComponent<PlayerController>().CheckAndSwitchWeapon();
            Destroy(gameObject);
        }
    }
}
