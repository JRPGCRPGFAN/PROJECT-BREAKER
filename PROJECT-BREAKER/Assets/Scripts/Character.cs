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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getCurrentVitality { get; set; }
    public int getVitality { get; set; }

}
