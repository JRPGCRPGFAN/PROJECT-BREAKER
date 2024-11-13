using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    protected override void ZeroVitality()
    {
        // TODO: Game Over. Not sure how we will handle this yet.
        throw new System.NotImplementedException("Game Over.");
    }

    private void FixedUpdate()
    {
        // Apply movement based on input
        if (goUp)
        {
            goUp = false;
            Movement.MoveUsingVelocity(rb2, Movement.Direction.Up, movementSpeed);
            //Debug.Log("Up");
        }
        else if (goDown)
        {
            goDown = false;
            Movement.MoveUsingVelocity(rb2, Movement.Direction.Down, movementSpeed);
            //Debug.Log("Down");
        }
        else if (goLeft)
        {
            goLeft = false;
            Movement.MoveUsingVelocity(rb2, Movement.Direction.Left, movementSpeed);
            //Debug.Log("Left");
        }
        else if (goRight)
        {
            goRight = false;
            Movement.MoveUsingVelocity(rb2, Movement.Direction.Right, movementSpeed);
            //Debug.Log("Right");
        }
        else
        {
            Movement.MoveUsingVelocity(rb2, Movement.Direction.None, movementSpeed);
        }

        // Apply attacks based on input
        if (basicAttack)
        {

        }

    }

    private void Update()
    {
        // Get movement input
        if (Input.GetKey(KeyCode.W))
        {
            goUp = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            goDown = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            goLeft = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            goRight = true;
        }

        // Get attack input
        if (Input.GetMouseButton(1))
        {
            basicAttack = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
        Movement.MoveWithForce(rb2, Movement.Direction.Right, movementSpeed*10000); // yettus deletus!!!! So we can still apply physics with triggers.
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exit");
    }
}
