using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Movement 
{

    public enum Direction : int
    { 
        Left,
        Right,
        Up,
        Down,
        None
    }

    // TODO: make this into a list type that cannot be edited.
    private static List<Vector2> directionList = new List<Vector2>();

    private static List<Vector3> rotationList = new List<Vector3>();


    static Movement()
    {
        Init();
    }

    private static void Init()
    {
        // Add in all the directions into the list to be used at a later date.
        // Each list enter index must match the direction enum.
        directionList.Add(Vector2.left); // Left = 0
        directionList.Add(Vector2.right); // Right = 1
        directionList.Add(Vector2.up); // Up = 2
        directionList.Add(Vector2.down); // Down = 3
        directionList.Add(Vector2.zero); // Down = 4

        rotationList.Add(new Vector3(0, 0, 180));
        rotationList.Add(new Vector3(0, 0, 0));
        rotationList.Add(new Vector3(0, 0, 90));
        rotationList.Add(new Vector3(0, 0, 270));
        rotationList.Add(new Vector3(0, 0, 0));
    }

    /// <summary>
    /// Move object using force. Constantly triggering this method will increase velocity of the rigidbody! 
    /// </summary>
    /// <param name="rigidbody"></param>
    /// <param name="direction"></param>
    public static void MoveWithForce(Rigidbody2D rigidbody, Direction direction, int speedModifier)
    {
        rigidbody.AddForce(directionList[(int)direction] * Time.deltaTime * speedModifier);
        if (!direction.Equals(Direction.None))
        {
            rigidbody.transform.rotation = Quaternion.Euler(rotationList[(int)direction]);
        }
    }

    /// <summary>
    /// Moves the object with a constant velocity.
    /// </summary>
    /// <param name="rigidbody"></param>
    /// <param name="direction"></param>
    /// <param name="speedModifier"></param>
    public static void MoveUsingVelocity(Rigidbody2D rigidbody, Direction direction, int speedModifier)
    {
        rigidbody.velocity = directionList[(int)direction] * Time.deltaTime * speedModifier;
        if (!direction.Equals(Direction.None))
        {
            rigidbody.transform.rotation = Quaternion.Euler(rotationList[(int)direction]);
        }
    }
}
