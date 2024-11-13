using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    public bool hasAgro = false;
    protected override void ZeroVitality()
    {
        // TODO: Drop loot for player and despawn object.
        Destroy(this.gameObject);
        throw new System.NotImplementedException("Drop Loot and Despawn object");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
