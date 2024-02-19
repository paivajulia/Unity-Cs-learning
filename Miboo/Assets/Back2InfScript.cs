using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back2InfScript : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementBack2();
    }
    private void MovementBack2()
    {
        Vector2 move = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = move;
    }
}
