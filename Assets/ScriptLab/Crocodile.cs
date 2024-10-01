using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodite : Enemy
{
    private float attackRance;
    private Player player;

    private void Start()
    {
        Initialized(50);
        Debug.Log("Crododile :" + Health);
        Behavior();
    }

    public void Shoot()
    {

    }
    public override void Behavior()
    {
        Debug.Log("Ceodile.behavior");
    }
}
