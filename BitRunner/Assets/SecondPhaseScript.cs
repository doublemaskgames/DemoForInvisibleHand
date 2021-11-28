using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPhaseScript : MonoBehaviour
{
    void Start()
    {
        PlayerParameters.MoveSpeed = 0;
    }

    public void StartGame(){
        StartCoroutine("startSecondPhase");
    }

    IEnumerator startSecondPhase(){
        yield return new WaitForSeconds(1);
        GameStateScript.state = GameState.goingOn;
    }

}
