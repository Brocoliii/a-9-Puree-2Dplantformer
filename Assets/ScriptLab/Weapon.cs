using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public void Initialized (int nDamage)
    {
        Damage = nDamage;
    }
    public int Damage
    {
        get;
        set;

    }
    public string Owner;
    public abstract void OnHitWith();
    public abstract void Move();
    public int GetShootDirection()
    {
        return Damage;  
    }

}
