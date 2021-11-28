using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallProjectileScript : SpawnedObject
{
    SoundManager soundManager;

    private void Start() {
        soundManager = FindObjectOfType<SoundManager>();
        soundManager.PlaySound(soundManager.shoot);
    }
    private void OnTriggerEnter2D(Collider2D other) {
    if(other.CompareTag("Enemy") ||other.CompareTag("KillWall")){
        Destroy(this.gameObject);
    }    
    }
}
