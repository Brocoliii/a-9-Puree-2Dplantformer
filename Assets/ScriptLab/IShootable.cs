using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable 
{
    GameObject Rock { get; set; }
    Transform RockSpawnPoint { get; set; }
    float rockWaitTime { get; set; }
    float rockTimer { get; set; }
    void Shoot();
}
