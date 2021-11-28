using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using DG.Tweening;
public class UITweening : MonoBehaviour
{
    public UnityEvent startGameEvent;
    public Transform cameraPosition;
    public RectTransform controlsMenu;
    public RectTransform bossWindow;
    SoundManager soundManager;

    void Start(){
        soundManager = FindObjectOfType<SoundManager>();
    }

    public void OpenControlsMenu(){
        controlsMenu.DOAnchorPos(new Vector2(2.5f, -32), 1);
    }
    public void CloseControlsMenu(){
        controlsMenu.DOAnchorPos(new Vector2(2.5f, 741), 1);
    }

    public void OpenBossMenu(){
        bossWindow.DOAnchorPos(new Vector2(2.5f, -740), 1);
    }
    public void CloseBossMenu(){
        bossWindow.DOAnchorPos(new Vector2(2.5f, 741), 1);
    }
   
    public void StartGame(){
        StartCoroutine("StartGameSequence");
    }
    

    IEnumerator StartGameSequence(){
        cameraPosition.DOMove(new Vector3(0, 0.5f, -10), 3);
        yield return new WaitForSeconds(3);
        startGameEvent.Invoke();
    }

   /* IEnumerator FadeOut(){
        GameStateScript.state = GameState.goingOn;
        yield return new WaitForSeconds(0.3f);
        soundManager.ChangeBGM(soundManager.BGMGameplay);
        for(float f = 1f; f>= -0.05f; f-=0.05f){
                Color c =titleScreen.material.color;
                c.a = f;
                titleScreen.material.color = c;
                yield return new WaitForSeconds(0.05f);
            }
        titleScreen.gameObject.SetActive(false);
    }*/
}
