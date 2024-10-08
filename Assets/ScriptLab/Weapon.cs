using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int Damage;
    

    protected string Owner;
    public abstract void OnHitWith(Character character);
        

    public abstract void Move();
    public int GetShootDirection()
    {
        return 1;  
    }

}
