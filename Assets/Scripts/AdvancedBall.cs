using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedBall : Ball // INHERITANCE
{
    public Rigidbody progectile;
    public Transform spawnPoint;

    private int projectileSpeed = 100;

    public bool canDoubleJump = false;
    public bool isJumping = false;


    public void Update()
    {
        Move();
        Jump();
        Shoot();
    }
    public override void Jump()
    {
        if (!isJumping & Input.GetKeyDown(KeyCode.Space))
        {
            jumpForce = 50f;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
            canDoubleJump = true;
        } 
        else if (canDoubleJump)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canDoubleJump = false;
            isJumping=false;
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

    }
    
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            Rigidbody rb = Instantiate(progectile, spawnPoint.position, spawnPoint.rotation);
            rb.velocity = transform.transform.forward * projectileSpeed;
        }
    }
}
