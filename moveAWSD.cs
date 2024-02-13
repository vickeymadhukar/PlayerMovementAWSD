using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAWSD : MonoBehaviour
{
    public float speed;
    private float moveinx;
    private float moveiny;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveinx = 0f;
        moveiny = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveinx * speed * Time.deltaTime, moveiny * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveiny = 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveinx = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveinx = 1;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveiny = -1;
        }
        if (Input.GetKeyUp(KeyCode.W)|| Input.GetKeyUp(KeyCode.S))
        {
            moveiny = 0;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            moveinx = 0;
        }
    }
}
