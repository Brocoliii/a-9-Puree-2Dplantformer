using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Banana : Weapon
{
    
    [SerializeField] private float speed;
    public void Start()
    {
        Damage = 40;
        Move();
        


    }
    
    public override void Move()
    {
        Debug.Log("Banana ����͹������ Transform ���¤������Ǥ����");
       
    }
    public override void OnHitWith(Character character)
    {

    }
    

}
