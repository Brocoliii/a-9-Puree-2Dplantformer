using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character , IShootable
{
    [field: SerializeField]
    GameObject rock;
    public GameObject Rock { get { return rock; } set { rock = value; } }
    [field: SerializeField]
    Transform rockSpawnPoint;
    public Transform RockSpawnPoint { get { return rockSpawnPoint; } set { rockSpawnPoint = value; } }
    public float rockWaitTime { get; set; }
    public float rockTimer { get; set; }

    public void Shoot() //กดเมาส์แล้วยิง
    {
        if (Input.GetButtonDown("Fire1") && rockWaitTime >= rockTimer)
        {
            GameObject obj = Instantiate(rock, RockSpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(10, this);
        }
        
    }
    void Start()
    {
        Initialized(100);
        rockTimer = 0.0f;
        rockWaitTime = 1.0f;

    }
    void Update() 
    { 
        Shoot();    
    
    }
    void FixedUpdate()
    { rockWaitTime += Time.fixedDeltaTime; }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null) { OnHitWith(enemy); }
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }    
}
