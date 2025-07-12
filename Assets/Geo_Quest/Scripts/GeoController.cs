
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    private Rigidbody2D rb;
    int varTwo = 3;
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }




        //if (Input.GetKeyDown(KeyCode.A))
        // {
        //    rb.velocity = new Vector2(-1, rb.velocity.y);
        //  }
        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //      rb.velocity = new Vector2(1, rb.velocity.x);
        //  }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            

            }
        private void OnTriggerStay2D(Collider2D collision)
        {
        
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
        
        }
}

