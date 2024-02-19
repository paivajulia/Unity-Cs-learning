using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float changeInterval = 2;
    public float minYPosition = 0;
    public float maxYPosition = 3;
    private float timer;
    private Vector2 randomDirection;
    // Start is called before the first frame update
    void Start()
    {
        timer = changeInterval;
        GenerateRandomDirection();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            GenerateRandomDirection();
            timer = changeInterval;
        }
        transform.Translate(randomDirection * moveSpeed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, minYPosition, maxYPosition));
    }
    void GenerateRandomDirection()
    {
        randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
}
