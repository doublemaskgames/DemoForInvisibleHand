using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : SpawnedObject
{
    private GameObject player;
    SoundManager soundManager;

    void Start(){
        soundManager = FindObjectOfType<SoundManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnDestroy() {
        soundManager.PlaySound(soundManager.hit);
    }
    new void Update(){
        base.Update();
        if(isCloseEnoughToAttack()){
            this.speed =2f;
        }
    }

    bool isCloseEnoughToAttack(){
        return(Vector3.Distance(this.transform.position, player.transform.position) < 3f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("KillWall") || other.CompareTag("Weapon")){
            Destroy(this.gameObject);
        }  
    }
}
