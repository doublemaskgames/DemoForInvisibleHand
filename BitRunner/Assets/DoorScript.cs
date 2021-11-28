using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : SpawnedObject
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("DoorStop")){
            this.speed =0;
        }else if(other.CompareTag("Player")){
            SceneManager.LoadScene(PlayerParameters.progressLevel);
            PlayerParameters.progressLevel++;
        }
    }
}
