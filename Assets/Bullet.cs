using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int _speed = 8;
    public Vector3 targetPos;

    private void Start()
    {
        
        
    }
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, _speed * Time.deltaTime);
        if (transform.position == targetPos)
        {
            Destroy(gameObject);
        }
    }
    
}
