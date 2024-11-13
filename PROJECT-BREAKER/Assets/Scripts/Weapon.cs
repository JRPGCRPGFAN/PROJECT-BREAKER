using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int attackStat = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Check if object is damagable.
        Character otherCharacter = other.GetComponent<Character>();
        otherCharacter.Defend(attackStat);
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exit");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO: Check if object is damagable.
        Character otherCharacter = collision.gameObject.GetComponent<Character>();
        otherCharacter.Defend(attackStat);
        Debug.Log("Collision Enter");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision Exit");
    }

}
