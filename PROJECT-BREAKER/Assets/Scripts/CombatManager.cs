/*
    Copyright © 2024 All Rights Reserved
    Class Name: CombatManager.cs
    Auther: EthanAllTheWay
    Date Created: July 29, 2024
    Last Edited By: EthanAllTheWay
    Date Edited: July 30, 2024
 */

/*
    ===== Notes =====
    
    Bug 01 - There is no order of operation for images, so sometimes one or more 
    of the characters are behind the background image.
    Bug 02 - I sometimes have to manually set the current vitality to the max 
    vitality in the CombatManager class otherwise the current vitality will be 0.
    Not sure why, but maybe someone would have said ghosts are causing it!
    
 */
using System;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    enum CombatStates 
    {
        Start,
        PlayerTurn,
        EnemyTurn,
        End
    }

    // TODO: Have a thing in place so we just populate the prefab for all characters. This includes the image, stats, etc.
    public GameObject characterPrefab;
    public List<GameObject> alliesGO;
    public List<GameObject> enemiesGO;

    public GameObject background;
    public HubManager hubManager;

    private List<Character> allies = new List<Character>();
    private List<Character> enemies = new List<Character>();
    private CombatStates currentCombatState = CombatStates.Start;

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    private void init()
    {
        // Spawn in background, allies, and enemies
        Instantiate(background);
        SetupCharactersUsingPrefabs();

        // TODO: Have something to decide whos goes first. For the moment, player always goes first.
        currentCombatState = CombatStates.PlayerTurn;

        // Setup All hub UI stuff.
        hubManager.SetupHub(allies, enemies);
    }

    /// <summary>
    /// Temporary script to set up characters, both allies and enemies, using premade prefabs. 
    /// TODO: I want to move away from this method since this will require a lot of unnecessary 
    /// prefab setup, but for now this will do the trick.
    /// </summary>
    private void SetupCharactersUsingPrefabs()
    {
        alliesGO.ForEach(ally => {
            Instantiate(ally);
            Character c = ally.GetComponent<Character>();
            c.LogStats();
            // TODO: See Bug 02 in the notes section.
            //c.CurrentVitality = c.MaxVitality;
            c.LogStats();
            allies.Add(c);
        });
        enemiesGO.ForEach(enemy => {
            Instantiate(enemy);
            enemies.Add(enemy.GetComponent<Character>());
        });
    }

    public void Update()
    {
        //CheckCombatState();
    }

    // Check if the combat state has changed. If it has, call manageCombatState() method otherwise do nothing.
    private void CheckCombatState()
    {
        throw new NotImplementedException();
    }


    private void manageCombatState()
    {
        
    }

    private void StartPlayerTurn()
    {
        // TODO: Activate intactable UI for the player to interact with.

    }

    private void StartEnemyTurn()
    { 
        // TODO: Call script for the enemy to do their thing.
    }

    private void EndBattle()
    { 
        // TODO: Either the player has won or a game over is in order. This method will handle that.
    }
}
