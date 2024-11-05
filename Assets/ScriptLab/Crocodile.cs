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
        rockTimer = 0.0f;
        rockWaitTime = 2.0f;
        
        
    }
     void FixedUpdate()
    {
        rockTimer -= Time.deltaTime;
        Behavior();
        //if (rockTimer >= rockWaitTime)
        //{
            //ockTimer = rockWaitTime;
        //}
    }

    public void Shoot()
    {
        if (rockTimer <= 0f)
        {
            //Animator.Setrigger("Shoot");

            GameObject obj = Instantiate(Rock, RockSpawnPoint.position, Quaternion.identity);
            rockTimer = rockWaitTime;
            Rock rockScript = obj.GetComponent<Rock>();
            rockScript.Init(20, this);
            
         }


    }
    public override void Behavior()
    {
        Vector2 distance = player.transform.position - transform.position; //หาทิศทาง 
        if (distance.magnitude < attackRance)
        {
            Shoot();
        }



    }
    
}
