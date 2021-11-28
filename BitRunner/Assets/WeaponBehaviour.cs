using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    SoundManager soundManager;

    private void OnEnable() {
        soundManager = FindObjectOfType<SoundManager>();
        soundManager.PlaySound(soundManager.slash);
        
    }
    void Start()
    {
        Invoke("Destroy",1);
    }

    void Destroy(){
        WeaponAction.weaponIsActive = false;
        Destroy(this.gameObject);
    }

}
