using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SamMoves : MonoBehaviour
{
    public groundDetector gd;
    // Start is called before the first frame update
    public float Speed;
    public float JumpSpeed;
    private Rigidbody rigidbod;
    float groundSpeed;
    float accelerateBro;
    float maxSpeed;
    float jumpSpeed;
    void Start()
    {
        rigidbod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //
    void Update()
    {

        float poisonEffect = 1f;

        float horizontal = 0;
        float vertical = 0;
        float yVelocity = rigidbod.velocity.y;
        

        bool Left = Input.GetKey(KeyCode.LeftArrow);
        bool Right = Input.GetKey(KeyCode.RightArrow);
        bool Up = Input.GetKey(KeyCode.UpArrow);
        bool Down = Input.GetKey(KeyCode.DownArrow);
        bool Space = Input.GetKeyDown(KeyCode.Space);
            //GetKey(KeyCode.Space);

        if (Left && Up)
        {
            vertical = 0.707f;
            horizontal = -0.707f;
        }
        else if (Left && Down)
        {
            vertical = -0.707f;
            horizontal = -0.707f;
        }
        else if (Right && Up)
        {
            vertical = 0.707f;
            horizontal = 0.707f;
        }
        else if (Right && Down)
        {
            vertical = -0.707f;
            horizontal = 0.707f;
        }

        if (Left && Right)
        {
            horizontal = 0;
        }
        else if(Left)
        {
            horizontal = -1;
        }    
        else if(Right) 
        {
            horizontal = 1;
        }


        if(Up && Down) 
        {
            vertical = 0;
        }
        else if(Up)
        {
            vertical = 1;
        }
        else if(Down)
        {
            vertical = -1;
        }

        if(Space && gd.isGrounded) 
        {
            yVelocity = JumpSpeed;
        }

        

        //transform.position += new Vector3(horizontal , height, vertical) * Speed;

        rigidbod.velocity = new Vector3(horizontal*Speed, yVelocity, vertical*Speed);


        // For moving diagonally, try to move in a diagonal direction with the magnitude direction at the same speed.
        // This will require some math to do
        // If keys like the left and up are pressed, the character should move in a diagonal direction.
        // If opposite keys are pressed, the character should not move
        // Try writing transform.position = new vector3(horizontal,0,vertical)*speed;
    }
}
