/*
    Copyright © 2024 All Rights Reserved
    Class Name: HubManager.cs
    Auther: EthanAllTheWay
    Date Created: July 29, 2024
    Last Edited By: EthanAllTheWay
    Date Edited: July 30, 2024
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubManager : MonoBehaviour
{
    [SerializeField]
    private BattleHUB battleHUB;

    [SerializeField]
    private PlayerActionHUB playerActionHUB;

    [SerializeField]
    private CombatManager combatManager;

    public void SetupHub(List<Character> allies, List<Character> enemies)
    {
        Character a = null;
        Character e = null;
        // Setup ally battle HUBs.
        allies.ForEach(ally => {
            battleHUB.SetupHUB(ally);
            a = ally;
        });
        enemies.ForEach(enemy => {
            battleHUB.SetupHUB(enemy);
            a = enemy;
        });

        playerActionHUB.init(this, a, e);
    }

    // Getters and Setters below.

    public BattleHUB BattleHUB 
    {
        get 
        {
            return battleHUB;
        }
        private set 
        {
            battleHUB = value;
        } 
    }

    public PlayerActionHUB PlayerActionHUB
    {
        get
        {
            return playerActionHUB;
        }
        private set
        {
            playerActionHUB = value;
        }
    }
}
