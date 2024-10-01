using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ant : Enemy
{
    private void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        Initialized(10);
        Debug.Log(Health);
        
    }
    private void FlipCharater()
    {
        velocity.x *= -1;

        Vector3 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;
    }


    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints; // array
    
    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime); //ตำแหน่ง + ความเร้ว * เวลา = ระยะทาง
        if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            FlipCharater();
            
        }
        
        else if  (rb.position.x <=  movePoints[0].position.x && velocity.x < 0  )
        {
            FlipCharater();    
        }
      
    }
    







}
