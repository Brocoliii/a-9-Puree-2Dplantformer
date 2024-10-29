using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodite : Enemy, IShootable
{
    [SerializeField] private float attackRance;
    [SerializeField] private Player player;

    [field:SerializeField]
    GameObject rock;
    public GameObject Rock { get {return rock; } set { rock = value; } }
    [field: SerializeField]
    Transform rockSpawnPoint;
    public Transform RockSpawnPoint { get { return rockSpawnPoint; } set { rockSpawnPoint = value; } }
    public float rockWaitTime { get; set; }
    public float rockTimer { get; set; }
    private void Start()
    {
        Initialized(50);
        Debug.Log(Health);
        
    }
    private void Update()
    {
        rockTimer -= Time.deltaTime;
        Behavior();
        if (rockTimer >= rockWaitTime)
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
