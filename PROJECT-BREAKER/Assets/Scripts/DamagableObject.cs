/*
    Copyright © 2024 All Rights Reserved
    Class Name: DamagableObject.cs
    Auther: EthanAllTheWay
    Date Created: July 29, 2024
    Last Edited By: EthanAllTheWay
    Date Edited: July 30, 2024
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamagableObject : MonoBehaviour
{
    public int maxVitality;
    protected int currentVitality;

    /// <summary>
    /// Deals damage to the current vitality based on the given amount. Will call the 
    /// ZeroVitality() method when current vitality is at or below zero.
    /// </summary>
    /// <param name="damageAmount"></param>
    protected void TakeDamage(int damageAmount)
    {
        if (damageAmount < 0)
        {
            // Why??? TODO: Properly handle this case.
            // Heal(-damageAmount);
            throw new System.Exception();
        }
        currentVitality -= damageAmount;
        if (currentVitality <= 0)
        {
            currentVitality = 0;
            ZeroVitality();
        }

    }

    /// <summary>
    /// Heals the current vitality up to the maximum amount based on the given amount.
    /// </summary>
    /// <param name="healAmount">The amount of vitality to heal.</param>
    protected void Heal(int healAmount)
    {
        if (healAmount < 0)
        {
            // Again, Why??? TODO: Properly handle this case.
            // TakeDamage(-healAmount);
            throw new System.Exception();
        }

        currentVitality += healAmount;
        if (currentVitality > maxVitality)
        {
            currentVitality = maxVitality;
        }
    }

    /// <summary>
    /// Method to trigger what will happen when the object reaches zero vitality.
    /// </summary>
    protected abstract void ZeroVitality();

    // Getters and Setters
    public int CurrentVitality { get { return currentVitality; } set { currentVitality = value; } }
    public int MaxVitality { get { return maxVitality; } set { maxVitality = value; } }

}
