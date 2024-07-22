using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    public List<GameObject> Allies;
    public List<GameObject> Enemies;
    public GameObject Background;

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    private void init()
    {
        // Spawn in background, allies, and enemies
        Instantiate(Background);
        Allies.ForEach(ally => {
            Instantiate(ally);
        });
        Enemies.ForEach(enemy => {
            Instantiate(enemy);
        });
    }
}
