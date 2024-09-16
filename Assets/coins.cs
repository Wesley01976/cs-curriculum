using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{

    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Object.Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameContoller").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
