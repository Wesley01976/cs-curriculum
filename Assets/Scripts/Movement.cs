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
    public PlayerController playerController;
    private bool jump;
    private RaycastHit2D leftray;
    private RaycastHit2D rightray;
    private Rigidbody2D rb;
    public float rayLength;
    


    // Start is called before the first frame update
    void Start()
    {
        playerController = FindFirstObjectByType<PlayerController>();
        xSpeed = 8;
        xDirection = 0;
        xVector = 0;
        ySpeed = 8;
        yDirection = 0;
        yVector = 0;
        rayLength = 1;
        
        rb = GetComponent<Rigidbody2D>();
        if (playerController.overworld)
        {
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 1;
        }
    }

    // Update is called once per frame
    void Update() 
    {
        xDirection = Input.GetAxis("Horizontal");
        
        xVector= xSpeed * xDirection * Time.deltaTime;
        
        
        
      
        leftray = Physics2D.Raycast(new Vector2(transform.position.x-trans.localScale.x/6,transform.position.y),Vector2.down, rayLength);
        rightray = Physics2D.Raycast(new Vector2(transform.position.x+trans.localScale.x/6,transform.position.y),Vector2.down, rayLength);
        
        Debug.DrawRay (new Vector2(transform.position.x+trans.localScale.x/6,transform.position.y),Vector2.down * rayLength);
        //TODO: we need to draw the ray and check the length. It is currently not touching the ground. Ask Ansell for help at the start of class.
        
        if (!playerController.overworld)
        {
            jump = Input.GetKeyDown(KeyCode.Space);
            ySpeed = 0;
            
            if ((leftray.collider != null ||rightray.collider != null) && jump)
            {
                rb.AddForce(new Vector2(0, 7.5f), ForceMode2D.Impulse);
            }
        }
        else
        {
            yDirection = Input.GetAxis("Vertical");
            ySpeed = 8;
            yVector = ySpeed * yDirection * Time.deltaTime;
        }
        
        trans.Translate(new Vector3(xVector, yVector, 0));
        
        
        


    }
    
}
