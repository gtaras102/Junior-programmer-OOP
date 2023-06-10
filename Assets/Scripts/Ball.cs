using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int speed = 10;
    private bool isJumping = false;
    public float jumpForce = 10f;

       
    

    public void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontalInput, 0, verticalInput);
    }
    
    public virtual void Jump()
    {
        if (!isJumping & Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }
        else
        {
            isJumping = false; 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    void Update()
    {
        Move();

        Jump();

    }
}
