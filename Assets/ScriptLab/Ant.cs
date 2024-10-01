using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Ant : Enemy
{
    private void Start()
    {
        Initialized(10);
        Debug.Log(Health);
        Behavior();
    }


    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints; // array
    

    
    public override void Behavior()
    {
       Debug.Log("Ant.behavior");
    }
    
        
    
}
