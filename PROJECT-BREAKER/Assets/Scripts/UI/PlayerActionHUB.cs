/*
    Copyright © 2024 All Rights Reserved
    Class Name: PlayerActionHUB.cs
    Auther: EthanAllTheWay
    Date Created: July 29, 2024
    Last Edited By: EthanAllTheWay
    Date Edited: July 30, 2024
 */

/*
    Notes:

    Bug: line 42, I think one of the character variables are null. Another day problem. :)
 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionHUB : MonoBehaviour
{

    private HubManager hubManager;
    private Character ally;
    private Character enemy;

    public void init(HubManager hubManager, Character enemy, Character ally)
    {
        this.hubManager = hubManager;
        this.ally = ally;
        this.enemy = enemy;

        Debug.Log("PlayerActionHUB.init() Called.");
    }

    enum AttackType
    { 
        Magic,
        Melee
    }

    /// <summary>
    ///
    /// </summary>
    public void AttackInput()
    {
        // TODO: Select Target. Enable that UI for the player to select the target.
        //enemy.
        enemy.GetAttacked(ally.Attack());
    }

}
