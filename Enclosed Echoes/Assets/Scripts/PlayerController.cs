using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    float horizontalInput;
    float verticalInput;

    bool onGround;


    Vector3 horizontalVelocity;
    Vector3 verticalVelocity;

    public float speed = 10f;
    public float jumpForce = 10f;
    public LayerMask floorMask;
    public Transform floorCheck;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    
    void Update() 
    {
        onGround = Physics.CheckSphere(floorCheck.position,0.1f,floorMask);
        
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
    }
    
    void FixedUpdate()
    {
        
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            horizontalVelocity = Vector3.right * horizontalInput * speed * Time.deltaTime;
            verticalVelocity = Vector3.forward * verticalInput * speed * Time.deltaTime;
        
            playerRb.velocity = horizontalVelocity + new Vector3 (0, playerRb.velocity.y,0) + verticalVelocity;  
        

    }

}
