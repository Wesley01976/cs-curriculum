using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enimy : MonoBehaviour



{
    public List<Transform> waypoints = new List<Transform>();

    private float _speed = 3f;
    private int currentPoint;
    public Vector3 targetPos;
    public bool icu ;


    private void Start()
    {
        currentPoint = 0;
        
    }

    private void Update()
    {


        if (!icu)
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
            

    }



    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, _speed * Time.deltaTime);
            targetPos = other.gameObject.transform.position;
            icu = true;
            _speed = 15f;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            icu = false;
        }
    }
}
