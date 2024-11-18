using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    public bool overworld;
    private bool jump;
    private RaycastHit2D leftray;
    private RaycastHit2D rightray;
    


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
      
        leftray = Physics2D.Raycast(new Vector2(transform.position.x-trans.localScale.x/2,transform.position.y),-Vector2.up, 0.3f);
        this.rightray = Physics2D.Raycast(new Vector2(transform.position.x+trans.localScale.x/2,transform.position.y),-Vector2.up, 0.3f);
        if (overworld != true)
        {
            jump = Input.GetKeyDown(KeyCode.Space);
        }

        xVector = Time.deltaTime * xSpeed * xDirection; 
        yVector = Time.deltaTime * ySpeed * yDirection;
        trans.Translate(new Vector3(xVector, yVector, 0));
        leftray = Physics2D.Raycast (new Vector2(transform.position.x - trans. localScale.x / 3, transform.position.y), -Vector2.up, 0.9f);
        this.rightray = Physics2D.Raycast (new Vector2(transform.position.x + trans. localScale.x/3, transform.position.y), -Vector2.up, 0.9f); 
        if ((leftray.collider != null ||rightray.collider != null) && jump)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7.5f), ForceMode2D.Impulse);
        }


    }
    
}
