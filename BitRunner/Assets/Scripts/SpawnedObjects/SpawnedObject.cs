using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
    public float speed;
    SoundManager soundManager;

    void Awake(){
      soundManager = FindObjectOfType<SoundManager>();
    }

    public void Update()
    {
      if(GameStateScript.state == GameState.paused) return;

      Move();

    }


    public void Move(){
         transform.Translate((transform.right * -(speed) * Time.deltaTime));
    }
}
