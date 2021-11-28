using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    paused, goingOn
}
public class GameStateScript : MonoBehaviour
{
    public static GameState state;
    void Start()
    {
        state = GameState.paused;
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void StartGame(){
        state = GameState.goingOn;
    }

    public void PauseGame(){
        state = GameState.paused;
    }
}
