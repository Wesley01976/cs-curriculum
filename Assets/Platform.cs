using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float _speed = 3f;
    public List<Transform> waypoints = new List<Transform>();
    private int currentPoint;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPoint].position,_speed * Time.deltaTime);
        
        if (Vector2.Distance(transform.position, waypoints[currentPoint].position) < 0.2f)
        {
            if (currentPoint < 1)
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
