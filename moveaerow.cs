using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveaerow : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveiny = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveinx = -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveinx = 1;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveiny = -1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            moveiny = 0;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveinx = 0;
        }
    }
}
