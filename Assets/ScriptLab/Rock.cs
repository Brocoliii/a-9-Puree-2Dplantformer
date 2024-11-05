using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon

{
    
    private Vector2 force;
    private Rigidbody2D rb2d;

    void Start()
    {
        Damage = 20;
        force = new Vector2 (GetShootDirection() * 100, 300);
        Move();
    }
    public override void Move()

    {
        //Debug.Log("Rock ����͹������ RigidBody : Force");
        rb2d.AddForce (force, ForceMode2D.Impulse);
        
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player )
        {
            character.TakeDamage(this.Damage);
        }
    }

}
