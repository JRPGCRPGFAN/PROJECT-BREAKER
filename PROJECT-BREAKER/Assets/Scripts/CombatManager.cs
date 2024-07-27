using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    public List<GameObject> allies;
    public List<GameObject> enemies;
    public GameObject background;

    public HubManager hubManager;

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    private void init()
    {
        // Spawn in background, allies, and enemies
        Instantiate(background);
        allies.ForEach(ally => {
            Instantiate(ally);
            Character c = ally.GetComponent<Character>();
            // TODO: Have it so we don't need to set character values in the initial setup.
            c.CurrentVitality = c.Vitality;
            c.LogStats();
            hubManager.BattleHUB.SetupHUB(c);
            c.LogStats();
        });
        enemies.ForEach(enemy => {
            Instantiate(enemy);
        });
    }
}
