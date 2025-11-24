using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParavaizAnimation : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(xMovement, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, yMovement);
    }
}
