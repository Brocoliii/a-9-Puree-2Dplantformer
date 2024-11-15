using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Banana : Weapon
{
    
    [SerializeField]  float speed;
    public void Start()
    {
        Damage = 10;
        
        speed = 3.0f * GetShootDirection();
    }
    

    public override void Move()
    {
        // Debug.Log("Banana ����͹������ Transform ���¤������Ǥ����");
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
           
    }
    private void FixedUpdate()
    {
        Move();
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
            character.TakeDamage(this.Damage);
    }
    

}
