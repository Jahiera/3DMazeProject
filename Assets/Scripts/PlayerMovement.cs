using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // we put information at the start
    // of a class
    public int health = 100;
    public float speed = 4.5f;
    public string hero = "Redd";
    public bool isAlive = true;

    //xyz directions
    public Vector3 direction;
    public Rigidbody playerRb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.linearVelocity = direction * speed;

        //the dot is there to access a functionality of "transform" translate means move
        //.Translate(direction * Time.deltaTime * speed);
    }

    private void OnMove(InputValue value)
    {
        //Asks the input system what keys are being pressed 
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }
}