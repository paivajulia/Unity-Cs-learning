using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpAmount = 10;
    public float gravityScale = 5;
    public float fallingGravityScale = 20;
    public float speed = 2;
    public float jumpForce = 5;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, y, 0);
        transform.Translate(movement * speed * Time.deltaTime);
        animator.SetFloat("X", movement.x);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);

        }
        if(myRigidbody.velocity.y >= 0)
        {
            myRigidbody.gravityScale = gravityScale;
        }
        else if (myRigidbody.velocity.y < 0)
        {
            myRigidbody.gravityScale = fallingGravityScale;
        }
    }
}
