using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon

{
    
    private Vector2 force;
    private Rigidbody2D rb;

    public void Start()
    {
        Damage = 40;
        Move();
    }
    public override void Move()

    {
        Debug.Log("Rock ����͹������ RigidBody : Force");
        
    }
    public override void OnHitWith(Character character)
    {

    }

}
