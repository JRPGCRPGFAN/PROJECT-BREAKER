using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    

    // Main Stats
    public int vitality;
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
    private int currentVitality;

    public void Start()
    {
        CurrentVitality = Vitality;
    }

    /// <summary>
    /// Logs to console character stats in json format.
    /// </summary>
    public void LogStats()
    {
        Debug.Log("{\"vitality\":\"" + vitality + "\"," +
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

    // Getters and Setters

    public int CurrentVitality { get { return currentVitality; } set { currentVitality = value; } }
    public int Vitality { get { return vitality; } set { vitality = value; } }
}
