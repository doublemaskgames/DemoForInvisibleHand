using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameEventChannel Victory = null;
    [SerializeField] private GameObject[] Spawnables =null;
    [SerializeField] private GameObject Door =null;
    [SerializeField] private GameObject target =null;
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
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, target.transform.position.z);  
        if(GameStateScript.state == GameState.goingOn){
            Spawn();
        }  
    }

    
    void Spawn(){
        if(spawnCount > spawnLimit) return;

        if(spawnTimer <= 0){   
            if(PlayerParameters.isAlive && spawnCount != spawnLimit){
                int RandomNumber = Random.Range(0,Spawnables.Length);
                Instantiate(Spawnables[RandomNumber], this.transform.position, this.transform.rotation);
                spawnTimer = Random.Range(minSec,maxSec);
                spawnCount++;
            }else{
                Instantiate(Door, this.transform.position, this.transform.rotation);
                spawnCount++;
                Victory.Raise();
            }
        }
        else{
            spawnTimer -= Time.unscaledDeltaTime;
        }


    }
}
