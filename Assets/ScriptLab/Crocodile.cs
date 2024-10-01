using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodite : Enemy
{
    [SerializeField] private float attackRance;
    [SerializeField] private Player player;
    [SerializeField] private GameObject Rock;
    [SerializeField] private Transform RockSpawnPoint;
    [SerializeField] private float rockWaitTime;
    [SerializeField] private float rockTimer;
    private void Start()
    {
        Initialized(50);
        Debug.Log(Health);
        
    }
    private void Update()
    {
        rockTimer -= Time.deltaTime;
        Behavior();
        if (rockTimer <0)
        {
            rockTimer = rockWaitTime;
        }
    }

    public void Shoot()
    {
        if(rockTimer < 0)
        Instantiate(Rock,RockSpawnPoint.position , Quaternion.identity);

    }
    public override void Behavior()
    {
        Vector2 direction = player.transform.position - transform.position; //หาทิศทาง
        float distance = direction.magnitude; //ระยะทาง
        if (distance < attackRance)
        {
            Shoot();
        }



    }
    
}
