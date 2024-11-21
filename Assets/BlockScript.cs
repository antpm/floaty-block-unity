using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class BlockScript : MonoBehaviour
{

    public int flapSpeed;
    public Rigidbody2D birdRigidBody;
    public LogicManagerScript logic;
    private Boolean alive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Gamepad.current.aButton.wasPressedThisFrame)
        {
            if (alive)
            {
                birdRigidBody.linearVelocity = Vector2.up * flapSpeed;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ceiling")
        {
            logic.gameOver();
            alive = false;
        }
        
    }
}
