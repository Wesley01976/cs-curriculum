using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float xSpeed;
    float xDirection;
    float xVector;
    public float ySpeed;
    float yDirection;
    float yVector;
    float Horiziontal;
    public Transform trans;
    float Vertical;


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 8;
        xDirection = 0;
        xVector = 0;
        ySpeed = 8;
        yDirection = 0;
        yVector = 0;

    }

    // Update is called once per frame
    void Update() {
        xDirection = Input.GetAxis("Horizontal");
        xVector= xSpeed * xDirection * Time.deltaTime;
        trans.Translate(new Vector3(xVector, yVector, 0));
        yDirection = Input.GetAxis("Vertical");
        yVector = ySpeed * yDirection * Time.deltaTime;
       

    }
    
}
