using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private TopDown_AnimatorController animatorController;
    public bool overworld;
    GameManager gm;
    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        animatorController = FindObjectOfType<TopDown_AnimatorController>();
        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?
        
        
        //
    }

    public void CheckAndSwitchWeapon()
    {
        if (gm.hasAxe)
        {
            animatorController.SwitchToAxe();
        }
        else
        {
            animatorController.SwitchToShovel();
        }
    }

    private void Update()
    {

        
    }
    
    
    
    
    //after all Unity functions, your own functions can go here
}