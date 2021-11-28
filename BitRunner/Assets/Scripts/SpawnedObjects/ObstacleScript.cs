using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : SpawnedObject
{
    public GameEventChannel gotHit;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            gotHit.Raise();
            Destroy(this.gameObject);
        }
        else if(other.CompareTag("KillWall")){
            Destroy(this.gameObject);
        }
    }
}
