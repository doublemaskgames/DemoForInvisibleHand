using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;

public class ThirdPhaseScript : MonoBehaviour
{
    public UnityEvent OpenBossWindow;
    public GameObject OpenThankYou;
    public TextMeshProUGUI ReadyGO;
    public bool isBossWindowOpen;
    void Start()
    {
        PlayerParameters.MoveSpeed = 0;
        StartCoroutine("startThirdPhase");
    }

    public void setWindowState(bool state){
        isBossWindowOpen = state;
    }

    public void End(){
        StartCoroutine("thankYouForPlaying");
    }


    IEnumerator startThirdPhase(){
        yield return new WaitForSeconds(1);
        OpenBossWindow.Invoke();
        while(isBossWindowOpen){
            yield return null;
        }
        yield return new WaitForSeconds(1);
        ReadyGO.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        ReadyGO.SetText("GO!");
        yield return new WaitForSeconds(1);
        ReadyGO.gameObject.SetActive(false);
        GameStateScript.state = GameState.goingOn;
    }

    IEnumerator thankYouForPlaying(){
        yield return new WaitForSeconds(3);
        OpenThankYou.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
