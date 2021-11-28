using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{
    [SerializeField] private GameEventChannel Victory = null;
    [SerializeField] private GameObject[] Spawnables =null;
    [SerializeField] private float minSec = 0;
    [SerializeField] private float maxSec = 0;
    [SerializeField] private int spawnLimit = 0;
    [SerializeField] private int spawnCount = 0;
    private float spawnTimer;
    [SerializeField] private PlayerParameters player = null;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(minSec, maxSec);
    }

    private void Update() { 
        if(GameStateScript.state == GameState.goingOn){
            Spawn();
        }  
    }

    
    void Spawn(){
       // if(spawnCount > spawnLimit) return;

        if(spawnTimer <= 0){   
            if(PlayerParameters.isAlive && spawnCount != spawnLimit){
                int RandomNumber = Random.Range(0,Spawnables.Length);
                Instantiate(Spawnables[RandomNumber], this.transform.position, this.transform.rotation, transform.parent);
                spawnTimer = Random.Range(minSec,maxSec);
                //spawnCount++;
            }
        }
        else{
            spawnTimer -= Time.unscaledDeltaTime;
        }


    }
}
