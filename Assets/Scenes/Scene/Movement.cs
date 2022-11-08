using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    float xInput;
    bool inputJump;
    Collision col;
    Rigidbody rb;
    public float maxVelocity = 10;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
            inputJump = true;
    }

    private void FixedUpdate()
    {

        float jump = 0;
        if (inputJump)
        {
            jump = 1;
            inputJump = false;
        }

        float xVelocity = Mathf.Clamp(rb.velocity.x + xInput * Time.fixedDeltaTime * speed, -maxVelocity, maxVelocity);

        rb.velocity = new Vector3(xVelocity,
            rb.velocity.y,
            0);
        rb.AddForce(Vector3.up * jump * jumpForce * Time.deltaTime, ForceMode.Impulse);

        if(col != null)
        {
            rb.AddExplosionForce(100, col.contacts[0].point, 100);
            col = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "AAA")
        {
            col = collision;
        }
    }
}
