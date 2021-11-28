using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class BigCubeScript : MonoBehaviour
{
    public GameEventChannel victory;
    public int Health;
    public TextMeshProUGUI healthText;

    void Update(){
        healthText.SetText("HP " + Health+ "/300");
    }

    public void Damage(int damage){
        Health -= damage;

        if(Health == 0){
            victory.Raise();
        }
    }

    public void Shake(){
        this.gameObject.transform.DOShakePosition(0.5f,2,10,90);
    }

    public void ShakeIntense(){
        this.gameObject.transform.DOShakePosition(10f,5,10,90);
    }


}
