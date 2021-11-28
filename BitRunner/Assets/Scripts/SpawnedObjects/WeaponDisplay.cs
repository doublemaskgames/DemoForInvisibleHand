using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponDisplay : MonoBehaviour
{
    WeaponAction weapon;
    SecondPhaseScript secondPhaseScript;
    PlayerParameters player;
    public ShopGenerator shopGenerator;
    public TextMeshProUGUI weaponDescription;
    public TextMeshProUGUI weaponName;
    public TextMeshProUGUI weaponPriceDisplay;
    public Image weaponArt;
    int weaponPrice;
    public WeaponScript weaponGenerated;

    public void GenerateWeapon(){
        for(int i=0; shopGenerator.activeWeapons.Count < shopGenerator.weapon.Length; i++){
            int RandomNumber = Random.Range(0, shopGenerator.weapon.Length);
            if(!shopGenerator.activeWeapons.Contains(shopGenerator.weapon[RandomNumber])){
                weaponGenerated = shopGenerator.weapon[RandomNumber];   
                shopGenerator.activeWeapons.Add(shopGenerator.weapon[RandomNumber]);
                break;
            }
        }
    }

    void Awake(){
        GenerateWeapon();
    }
    void Start()
    {
        weapon = FindObjectOfType<WeaponAction>();
        secondPhaseScript = FindObjectOfType<SecondPhaseScript>();
        weaponName.SetText(weaponGenerated.name);
        weaponDescription.SetText(weaponGenerated.description);
        weaponArt.sprite = weaponGenerated.art;
        weaponPrice = weaponGenerated.price;
        weaponPriceDisplay.SetText(weaponPrice.ToString());
    }

    public void BuyWeapon(){
        if(PlayerParameters.coins >= weaponPrice){
            weapon.weaponEquipped = weaponGenerated.weapon; 
            PlayerParameters.coins -= weaponPrice;
            shopGenerator.activeWeapons.Clear();
            secondPhaseScript.StartGame();
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}
