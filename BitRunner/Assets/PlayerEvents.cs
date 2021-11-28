using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerEvents : MonoBehaviour
{
    public UnityEvent gameOverEvent;
    SoundManager soundManager;

    private void Awake() {
        soundManager = GetComponent<SoundManager>();
    }
    public void AddCoins(){
        soundManager.PlaySound(soundManager.coin);
        PlayerParameters.coins++;
    }

    public void LoseHealth(){
        soundManager.PlaySound(soundManager.hit);
        PlayerParameters.health--;

        if(PlayerParameters.health == 0){
            StartCoroutine("GameOver");
        }
    }

    public void Victory(){
        StartCoroutine("VictoryAnimation");
    }

    public IEnumerator GameOver(){
        PlayerParameters.isAlive = false;
        gameOverEvent.Invoke();
        GameStateScript.state = GameState.paused;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
    public IEnumerator VictoryAnimation(){
        yield return new WaitForSeconds(1);
        PlayerParameters.MoveSpeed =2;
        yield return null;
    }

    public void Reset(){
    PlayerParameters.isAlive = true;
    PlayerParameters.JumpSpeed = 10;
    PlayerParameters.MoveSpeed = 0;
    PlayerParameters.progressLevel = 1;
    PlayerParameters.coins = 0;
    PlayerParameters.health = 3;
    }
}
