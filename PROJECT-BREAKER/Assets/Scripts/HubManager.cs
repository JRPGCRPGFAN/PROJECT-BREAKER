using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubManager : MonoBehaviour
{
    [SerializeField]
    private BattleHUB battleHUB;

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

}
