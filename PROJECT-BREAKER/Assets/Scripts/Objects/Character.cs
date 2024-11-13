/*
    Copyright © 2024 All Rights Reserved
    Class Name: Character.cs
    Auther: EthanAllTheWay
    Date Created: July 29, 2024
    Last Edited By: EthanAllTheWay
    Date Edited: July 30, 2024
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : DamagableObject
{

    // Main Stats
    //public int maxVitality;
    public int stamina;
    public int defense;
    public int strength;
    public int intelligence;
    public int concentration;
    public int dexterity;
    public int agility;
    public int accuracy;
    public int actionPoints;

    public string characterName;
    //private int currentVitality;
    public Rigidbody2D rb2;
    public int movementSpeed = 5;
    public GameObject weapon;


    protected bool goLeft = false;
    protected bool goRight = false;
    protected bool goUp = false;
    protected bool goDown = false;
    protected bool basicAttack = false;

    public void Awake()
    {
        CurrentVitality = maxVitality;
    }

    public void Start()
    {
        // This is temperary. TODO: We will need to have a place to store this info as
        // well as be able to grab that info for times like these.
        CurrentVitality = maxVitality;
    }

    /// <summary>
    /// Logs to console character stats in json format.
    /// </summary>
    public void LogStats()
    {
        Debug.Log("{\"vitality\":\"" + maxVitality + "\"," +
            "{\"stamina\":\"" + stamina + "\"," +
            "{\"defense\":\"" + defense + "\"," +
            "{\"strength\":\"" + strength + "\"," +
            "{\"intelligence\":\"" + intelligence + "\"," +
            "{\"concentration\":\"" + concentration + "\"," +
            "{\"dexterity\":\"" + dexterity + "\"," +
            "{\"agility\":\"" + agility + "\"," +
            "{\"accuracy\":\"" + accuracy + "\"," +
            "{\"actionPoints\":\"" + actionPoints + "\"," +
            "{\"characterName\":\"" + characterName + "\"," +
            "{\"currentVitality\":\"" + currentVitality + "\"}");
    }

    //protected override void ZeroVitality()
    //{
    //    Destroy(this.gameObject);
    //    //throw new System.NotImplementedException();
    //}

    /// <summary>
    /// Method to calculate the amount of damage the character will deal to the player without info of enemies stats.
    /// </summary>
    /// <returns>The amount of pontential damage the character can deal.</returns>
    public int Attack()
    {

        // TODO: calculate character stats into this.
        return strength;
    }

    /// <summary>
    /// Method to calculate the amount of damage the character will take after taking into account defenses, armor, and such. 
    /// </summary>
    /// <param name="incomingDamage">The amount of potential damage the character can take.</param>
    /// <returns></returns>
    public int Defend(int incomingDamage)
    {
        // TODO: calculate character stats into this.
        Debug.Log("Vitality Before: " + currentVitality);
        TakeDamage(incomingDamage);
        Debug.Log("Vitality After: " + currentVitality);
        return currentVitality;
    }



    // Getters and Setters

    //public int CurrentVitality { get { return currentVitality; } set { currentVitality = value; } }
    //public int Vitality { get { return maxVitality; } set { maxVitality = value; } }


}
