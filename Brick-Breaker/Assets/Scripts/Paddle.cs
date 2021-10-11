using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D pRb;
    // Start is called before the first frame update
    void Start()
    {
        pRb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, -4.5F);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") && transform.position.x > -5.5f)
        {
            pRb.velocity = new Vector2(-10, 0);
        }
        else if (Input.GetKey("right") && transform.position.x < 5.5F)
        {
            pRb.velocity = new Vector2(10, 0);
        }
        else
        {
            pRb.velocity = Vector2.zero;
        }
    }
}
