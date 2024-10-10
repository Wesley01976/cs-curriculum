using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enimy : MonoBehaviour


{
    public List<Transform> waypoints = new List<Transform>();

    private float _speed = 3f;
    private int currentPoint;


    private void Start()
    {
        currentPoint = 0;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPoint].position, _speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoints[currentPoint].position)<0.2f)
        {
            if (currentPoint<2)
            {
                currentPoint += 1;
            }
            else
            {
                currentPoint = 0;
            }
        }
    }
}
