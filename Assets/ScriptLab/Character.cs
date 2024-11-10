using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour

{
    public HeartBar heartBar;
    public Animator anim;
    public Rigidbody2D rb;

    public void Initialized(int newHealth)
    {
        Health = newHealth;
        heartBar.SetMaxHealth(newHealth);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    [SerializeField]private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

 
    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;
    }
    public void TakeDamage(int damage )
    {
        Health -= damage;
        heartBar.UpdateHealthBar(health);
        IsDead();
        
    }

    
        
        
         
        
        
        
           
       

}
