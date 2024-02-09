using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    public float flapStrength;
    public LogicScript logic;
    public bool catIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && catIsAlive == true)
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength; 
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
