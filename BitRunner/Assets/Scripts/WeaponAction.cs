using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAction : MonoBehaviour
{
    public GameObject weaponEquipped;
    public GameObject player;

    public static bool weaponIsActive = false;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update(){
        if(GameStateScript.state == GameState.paused) return;

        if(Input.GetKeyDown(KeyCode.Mouse1) && !weaponIsActive){
            Attack();
        }
    }

    public void Attack(){
        weaponIsActive = true;
        Instantiate(weaponEquipped, player.transform.position + new Vector3(2,0,0), this.transform.rotation);
    }
}
