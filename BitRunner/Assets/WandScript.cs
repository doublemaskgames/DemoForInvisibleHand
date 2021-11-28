using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandScript : WeaponBehaviour
{
    public GameObject FireBall;
    private void OnEnable() {
        Instantiate(FireBall, this.transform.position + new Vector3(1,0,0), this.transform.rotation);
    }
}
