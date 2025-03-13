using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // we put information at the start
    // of a class
    public float speed = 4.5f;
    public float jumpForce = 5;
    public string hero = "Redd";

    //xyz directions
    public Vector3 direction;
    public Rigidbody playerRb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocity = direction * speed;
        velocity.y = playerRb.linearVelocity.y;
        
        playerRb.linearVelocity = velocity;

        //Vector3 is XYZ, Vector2 is XY
        //the dot is there to access a functionality of "transform" translate means move
        //.Translate(direction * Time.deltaTime * speed);
               
    }

    private void OnMove(InputValue value)
    {
        //Asks the input system what keys are being pressed 
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }

    private void OnJump(InputValue value)
    {
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    
}