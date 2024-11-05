using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.VersionControl;
using UnityEngine;

public class Enimy : MonoBehaviour



{
    public List<Transform> waypoints = new List<Transform>();

    private float _speed = 3f;
    private int currentPoint;
    public Vector3 targetPos;
    public bool icu ;
    bool StartofState = true;
    States state;
    public GameManager gm;
    private float Cooldown;

    private enum States
    {
        patrol,
        chase,
        attack,
        die
        
    }


    private void Start()
    {
        currentPoint = 0;
        state = States.patrol;
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (state==States.patrol)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPoint].position,_speed * Time.deltaTime);
            _speed = 3f;
        }
            
                
        if (Vector2.Distance(transform.position, waypoints[currentPoint].position) < 0.2f)
        {
            if (currentPoint < 2)
            {
                currentPoint += 1;
            }
            else
            {
                currentPoint = 0;
            }
        }

        if (state == States.attack)
        {
            if (Cooldown<0)
            {
                gm.changeHealth(-1);
                Cooldown = 1;   
            }
        }
        Cooldown -= Time.deltaTime;
    }



    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            targetPos = other.gameObject.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, _speed * Time.deltaTime);
            icu = true;
            _speed = 3f;

           
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (state == States.chase)
            {
                state = States.attack;
                print("enter attack");
            }

            if (state==States.patrol)
            {
                state = States.chase;
                print("enter chase");
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (state == States.chase)
            {
                state = States.patrol;
                print("enter attack");
                {
                    
                }
            }

            if (state==States.attack)
            {
                state = States.chase;
                print("enter chase");
            }
            
        }
    } 
}
