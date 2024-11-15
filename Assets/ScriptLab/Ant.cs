using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ant : Enemy
{
    private void Start()
    {
        //rb = GetComponent <Rigidbody2D>();
        Initialized(10);
        //Debug.Log(Health);
        
    }
    private void FlipCharater()
    {
        velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }


    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints; // array
    
    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            FlipCharater();

        }
        else if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            FlipCharater();
        }

    }
    







}
