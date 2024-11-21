using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class BlockScript : MonoBehaviour
{

    public int flapSpeed;
    public Rigidbody2D birdRigidBody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Gamepad.current.aButton.wasPressedThisFrame)
        {
            birdRigidBody.linearVelocity = Vector2.up * flapSpeed;
        }
    }
}
