using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ShopGenerator : ScriptableGameObject
{
    public WeaponScript[] weapon;
    public List<WeaponScript> activeWeapons = new List<WeaponScript>();

    void OnDisable(){
        activeWeapons.Clear();
    }
}
